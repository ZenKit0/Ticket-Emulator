using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketEmulator {
    class Const {
        public const string NotEnoughMoney = "Nie posiadasz pieniędzy na koncie.";
        public const string Active = "Aktywny";
        public const string Not_Active = "Nieaktywny";
        public const string Incorrect_Code = "Niepoprawny kod";

        public static string GetDatabasePath() {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Ticket_database";
        }
    }
}
