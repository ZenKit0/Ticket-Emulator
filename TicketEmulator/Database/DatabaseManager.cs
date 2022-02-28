using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TicketEmulator.Utils;
using TicketEmulator.Utils.Log;

namespace TicketEmulator.Database
{
    class DatabaseManager
    {
        #region ID_variables
        private const int CurrentLineId = 109;
        private const int CurrentBusStopId = 92;
        private const int CurrentVehicleId = 10;
        private static int CurrentDay;
        private static int CurrentMonth;
        private static int CurrentHour;
        private static int CurrentMinute;
        #endregion

        #region Ticket_variables
        public float CurrentMoney = 90f;

        public readonly List<float> TicketCost = new List<float>() {
            2.00f,
            3.50f,
            4.00f,
            6.00f
        };

        public readonly List<int> TicketTimeType = new List<int>() {
            20,
            40,
            20,
            40
        };

        public readonly List<string> TicketAgeType = new List<string>() {
            "U",
            "U",
            "N",
            "N"
        };
        #endregion

        /// <summary>
        /// List which store all Tickets
        /// </summary>
        public List<Ticket> Tickets;
        private string path = Const.GetDatabasePath() + "/DB.txt";

        public DatabaseManager() {
            Tickets = new List<Ticket>();
        }

        /// <summary>
        /// Loads Database from path and add all Tickets to List
        /// </summary>
        /// <param name="path"></param>
        public void LoadDatabase() {
            if (File.Exists(path))
            {
                Tickets = new List<Ticket>();
                var fileReader = new StreamReader(path);
                var fileLength = File.ReadLines(path).Count();
                for (int i = 0; i < fileLength; i++) {
                    var tempTicket = ConvertStringToTicket(fileReader.ReadLine());
                    Tickets.Add(tempTicket);
                }
                fileReader.Close();
            }
        }

        /// <summary>
        /// Save all Tickets to Database file in selected path
        /// </summary>
        /// <param name="path"></param>
        public void SaveDatabase()
        {
            if (!File.Exists(path))
                File.CreateText(path);

            var streamWriter = new StreamWriter(path);
            foreach (var obj in Tickets)
                streamWriter.WriteLine(ConvertTicketToString(obj));
            streamWriter.Close();
        }

        /// <summary>
        /// Converts formated text to Ticket
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Ticket</returns>
        public Ticket ConvertStringToTicket(string text) {
            if (text != null) {
                var convertedString = text.Split('_').ToList();
                var temporaryTicket = new Ticket(new int[8], "");
                temporaryTicket.ConvertArrayToProperties(convertedString);
                return temporaryTicket;
            }
            return null;
        }

        public bool CheckCorrectionOfTicket(string text)
        {
            if (text == null || text.Split('_').ToList().Count < 9)
                return false;

            var textList = text.Split('_').ToList();
            if (textList[0].Length >= 2 &&
                textList[1].Length == 2 &&
                textList[2].Length == 2 &&
                textList[3].Length >= 1 &&
                textList[4].Length >= 1 &&
                textList[5].Length >= 1 &&
                textList[6].Length >= 1 &&
                textList[7].Length == 2 &&
                textList[8].Length == 1)
                return true;

            return false;
        }

        /// <summary>
        /// Converts Ticket object to formatted string
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>Formatted string</returns>
        public string ConvertTicketToString(Ticket ticket) {
            if (ticket != null) {
                List<string> tempList = new List<string>();
                tempList.Add(ticket.LineID.ToString());
                tempList.Add(ticket.Bus_stopID.ToString());
                tempList.Add(ticket.VehicleID.ToString());
                tempList.Add(ticket.Day.ToString());
                tempList.Add(ticket.Month.ToString());
                tempList.Add(ticket.Hour.ToString());
                tempList.Add(ticket.Minute.ToString());
                tempList.Add(ticket.TicketTimeType.ToString());
                tempList.Add(ticket.TicketAgeType);
                var temporaryString = string.Join("_", tempList);
                return temporaryString;
            }
            return null;
        }

        public enum FindTicketValues
        {
            Find_yes,
            Find_no
        }

        /// <summary>
        /// Find ticket by checking properties to database properties. Returns ticket if found and null if not found.
        /// Checks time to expire ticket.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>Ticket</returns>
        public FindTicketValues FindTicket(Ticket ticket) {
            if (ticket.Month > 12 || ticket.Hour > 24 || ticket.Minute > 60 || ticket.Day > 31)
                return FindTicketValues.Find_no;

            foreach (var item in Tickets) {
                if (item.IfEqual(ticket)) {
                    var Time_Ticket = new DateTime(DateTime.Now.Year, ticket.Month, ticket.Day, ticket.Hour, ticket.Minute, DateTime.Now.Second);
                    var Time_Now = DateTime.Now;
                    var Time = Time_Now - Time_Ticket;
                    if (Time.TotalMinutes > Convert.ToDouble(ticket.TicketTimeType) + 1)
                        return FindTicketValues.Find_no;

                    return FindTicketValues.Find_yes;
                }
            }

            return FindTicketValues.Find_no;
        }

        /// <summary>
        /// Return all information as Ticket
        /// </summary>
        /// <returns>Ticket</returns>
        public Ticket GetInformations(int Index)
        {
            CurrentDay = DateTime.Now.Day;
            CurrentMonth = DateTime.Now.Month;
            CurrentHour = DateTime.Now.Hour;
            CurrentMinute = DateTime.Now.Minute;
            Ticket tempTicket = new Ticket(new [] {
                CurrentLineId, 
                CurrentBusStopId, 
                CurrentVehicleId, 
                CurrentDay, 
                CurrentMonth, 
                CurrentHour, 
                CurrentMinute,
                TicketTimeType[Index],
            }, TicketAgeType[Index]);
            return tempTicket;
        }

        public void AddTicketToDatabase(Ticket ticket)
        {
            var streamWriter = new StreamWriter(path, true);
            Tickets.Add(ticket);
            streamWriter.WriteLine(ConvertTicketToString(ticket));
            streamWriter.Close();
        }
    }
}
