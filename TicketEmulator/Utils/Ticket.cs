using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketEmulator.Utils
{
    class Ticket
    {
        public Ticket(int[] args, string argAge)
        {
            LineID = args[0];
            Bus_stopID = args[1];
            VehicleID = args[2];
            Day = args[3];
            Month = args[4];
            Hour = args[5];
            Minute = args[6];
            TicketTimeType = args[7];
            TicketAgeType = argAge;
        }

        // ID's
        public int LineID;
        public int Bus_stopID;
        public int VehicleID;
        
        // Date Informations
        public int Day;
        public int Month;
        public int Hour;
        public int Minute;
        public int TicketTimeType;
        public string TicketAgeType { get; set; }

        public bool IfEqual(Ticket other)
        {
            if (other == null)
                return false;

            if (LineID == other.LineID &&
                Bus_stopID == other.Bus_stopID &&
                VehicleID == other.VehicleID &&
                Day == other.Day &&
                Month == other.Month &&
                Hour == other.Hour &&
                TicketTimeType == other.TicketTimeType &&
                TicketAgeType == other.TicketAgeType)
                return true;
            return false;
        }

        /// <summary>
        /// Converts variables in selected array to Ticket properties
        /// </summary>
        /// <param name="arrayStrings"></param>
        public void ConvertArrayToProperties(List<string> arrayStrings)
        {
            int.TryParse(arrayStrings[0], out LineID);
            int.TryParse(arrayStrings[1], out Bus_stopID);
            int.TryParse(arrayStrings[2], out VehicleID);
            int.TryParse(arrayStrings[3], out Day);
            int.TryParse(arrayStrings[4], out Month);
            int.TryParse(arrayStrings[5], out Hour);
            int.TryParse(arrayStrings[6], out Minute);
            int.TryParse(arrayStrings[7], out TicketTimeType);
            TicketAgeType = arrayStrings[8];
        }
    }
}
