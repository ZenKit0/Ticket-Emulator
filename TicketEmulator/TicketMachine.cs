using System;
using System.Drawing;
using System.Windows.Forms;
using TicketEmulator.Database;
using TicketEmulator.Utils;
using TicketEmulator.Utils.Log;

namespace TicketEmulator
{
    public partial class TicketMachine : Form
    {
        DatabaseManager DB = new DatabaseManager();
        private int TicketIndex;

        public TicketMachine()
        {
            Log.ClearLogs();
            InitializeComponent();
            DB.LoadDatabase();
            CurrentMoneyText.Text = String.Format("{0:0.00}", DB.CurrentMoney);
        }

        private void TicketList_SelectedIndexChanged(object sender, EventArgs e) { 
            TicketIndex = TicketList.SelectedIndex;
            TicketPrice.Text = $"{String.Format("{0:0.00}", DB.TicketCost[TicketIndex])} zł";
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e) {
            if (DB.CurrentMoney >= DB.TicketCost[TicketIndex])
            {
                DB.CurrentMoney -= DB.TicketCost[TicketIndex];
                CurrentMoneyText.Text = String.Format("{0:0.00}", DB.CurrentMoney);

                Ticket tempTicket = DB.GetInformations(TicketIndex);
                TicketNumber.Text = DB.ConvertTicketToString(tempTicket);
                DB.AddTicketToDatabase(tempTicket);
            } else {
                TicketNumber.Text = Const.NotEnoughMoney;
            }
        }

        private void CheckTicketBtn_Click(object sender, EventArgs e)
        {
            if (!DB.CheckCorrectionOfTicket(NumberToCheck.Text)) {
                CheckResult.ResetBackColor();
                CheckResult.ResetForeColor();
                CheckResult.Text = Const.Incorrect_Code;
                return;
            }

            Ticket tempTicket = DB.ConvertStringToTicket(NumberToCheck.Text);
            var ticketFounded = DB.FindTicket(tempTicket);
            switch (ticketFounded)
            {
                case DatabaseManager.FindTicketValues.Find_yes:
                    CheckResult.BackColor = Color.Green;
                    CheckResult.ForeColor = Color.White;
                    CheckResult.Text = Const.Active;
                    break;
                default:
                    CheckResult.BackColor = Color.Red;
                    CheckResult.ForeColor = Color.White;
                    CheckResult.Text = Const.Not_Active;
                    break;
            }
        }
    }
}
