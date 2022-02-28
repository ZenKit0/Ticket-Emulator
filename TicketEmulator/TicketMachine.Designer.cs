
namespace TicketEmulator
{
    partial class TicketMachine
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicketNumber = new System.Windows.Forms.TextBox();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.TicketList = new System.Windows.Forms.ListBox();
            this.TicketPrice = new System.Windows.Forms.TextBox();
            this.TicketPriceInformation = new System.Windows.Forms.TextBox();
            this.AccountMoney = new System.Windows.Forms.TextBox();
            this.CurrentMoneyText = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumberToCheck = new System.Windows.Forms.TextBox();
            this.CheckResult = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CheckTicketBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicketNumber
            // 
            this.TicketNumber.Location = new System.Drawing.Point(12, 128);
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.ReadOnly = true;
            this.TicketNumber.Size = new System.Drawing.Size(231, 20);
            this.TicketNumber.TabIndex = 0;
            this.TicketNumber.Text = "Numer twojego biletu";
            this.TicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.Location = new System.Drawing.Point(13, 13);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(88, 23);
            this.BuyTicketBtn.TabIndex = 1;
            this.BuyTicketBtn.Text = "Kup Bilet";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // TicketList
            // 
            this.TicketList.FormattingEnabled = true;
            this.TicketList.Items.AddRange(new object[] {
            "Ulgowy 20-minut",
            "Ulgowy 40-minut",
            "Normalny 20-minut",
            "Normalny 40-minut"});
            this.TicketList.Location = new System.Drawing.Point(123, 13);
            this.TicketList.Name = "TicketList";
            this.TicketList.Size = new System.Drawing.Size(120, 56);
            this.TicketList.TabIndex = 2;
            this.TicketList.SelectedIndexChanged += new System.EventHandler(this.TicketList_SelectedIndexChanged);
            // 
            // TicketPrice
            // 
            this.TicketPrice.Location = new System.Drawing.Point(87, 78);
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            this.TicketPrice.Size = new System.Drawing.Size(156, 20);
            this.TicketPrice.TabIndex = 3;
            // 
            // TicketPriceInformation
            // 
            this.TicketPriceInformation.Location = new System.Drawing.Point(13, 78);
            this.TicketPriceInformation.Name = "TicketPriceInformation";
            this.TicketPriceInformation.ReadOnly = true;
            this.TicketPriceInformation.Size = new System.Drawing.Size(68, 20);
            this.TicketPriceInformation.TabIndex = 4;
            this.TicketPriceInformation.Text = "Cena biletu:";
            this.TicketPriceInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountMoney
            // 
            this.AccountMoney.Location = new System.Drawing.Point(12, 325);
            this.AccountMoney.Name = "AccountMoney";
            this.AccountMoney.ReadOnly = true;
            this.AccountMoney.Size = new System.Drawing.Size(68, 20);
            this.AccountMoney.TabIndex = 5;
            this.AccountMoney.Text = "Stan Konta:";
            this.AccountMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentMoneyText
            // 
            this.CurrentMoneyText.Location = new System.Drawing.Point(12, 351);
            this.CurrentMoneyText.Name = "CurrentMoneyText";
            this.CurrentMoneyText.ReadOnly = true;
            this.CurrentMoneyText.Size = new System.Drawing.Size(231, 20);
            this.CurrentMoneyText.TabIndex = 6;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(308, 13);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(444, 20);
            this.Information.TabIndex = 7;
            this.Information.Text = "109             |_92               |_10                         |_25     |_1     " +
    "     |_22         |_12      |_20    |_U\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Numer Linii | Numer Busa | Numer Przystanku | Dzień | Miesiąc | Godzina | Minuta " +
    "| Czas | Typ ";
            // 
            // NumberToCheck
            // 
            this.NumberToCheck.Location = new System.Drawing.Point(304, 154);
            this.NumberToCheck.Name = "NumberToCheck";
            this.NumberToCheck.Size = new System.Drawing.Size(448, 20);
            this.NumberToCheck.TabIndex = 10;
            this.NumberToCheck.Text = "Wpisz swój numer biletu";
            this.NumberToCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckResult
            // 
            this.CheckResult.Location = new System.Drawing.Point(644, 198);
            this.CheckResult.Name = "CheckResult";
            this.CheckResult.ReadOnly = true;
            this.CheckResult.Size = new System.Drawing.Size(108, 20);
            this.CheckResult.TabIndex = 11;
            this.CheckResult.Text = "Aktywny/Nieaktywny";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(535, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Bilet:";
            // 
            // CheckTicketBtn
            // 
            this.CheckTicketBtn.Location = new System.Drawing.Point(452, 125);
            this.CheckTicketBtn.Name = "CheckTicketBtn";
            this.CheckTicketBtn.Size = new System.Drawing.Size(153, 23);
            this.CheckTicketBtn.TabIndex = 14;
            this.CheckTicketBtn.Text = "Sprawdź Bilet";
            this.CheckTicketBtn.UseVisualStyleBackColor = true;
            this.CheckTicketBtn.Click += new System.EventHandler(this.CheckTicketBtn_Click);
            // 
            // TicketMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckTicketBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CheckResult);
            this.Controls.Add(this.NumberToCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.CurrentMoneyText);
            this.Controls.Add(this.AccountMoney);
            this.Controls.Add(this.TicketPriceInformation);
            this.Controls.Add(this.TicketPrice);
            this.Controls.Add(this.TicketList);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.TicketNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TicketMachine";
            this.Text = "MPK - Automat biletowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TicketNumber;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.ListBox TicketList;
        private System.Windows.Forms.TextBox TicketPrice;
        private System.Windows.Forms.TextBox TicketPriceInformation;
        private System.Windows.Forms.TextBox AccountMoney;
        private System.Windows.Forms.TextBox CurrentMoneyText;
        private System.Windows.Forms.TextBox Information;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NumberToCheck;
        private System.Windows.Forms.TextBox CheckResult;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button CheckTicketBtn;
    }
}

