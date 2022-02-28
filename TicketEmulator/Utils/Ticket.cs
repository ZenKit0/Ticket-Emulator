using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Example for Ticket code:
// 109_92_10_25_1_22_12

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
            LineID = Int32.Parse(arrayStrings[0]);
            Bus_stopID = Int32.Parse(arrayStrings[1]);
            VehicleID = Int32.Parse(arrayStrings[2]);
            Day = Int32.Parse(arrayStrings[3]);
            Month = Int32.Parse(arrayStrings[4]);
            Hour = Int32.Parse(arrayStrings[5]);
            Minute = Int32.Parse(arrayStrings[6]);
            TicketTimeType = Int32.Parse(arrayStrings[7]);
            TicketAgeType = arrayStrings[8];
        }
    }
}
