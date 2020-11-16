using System.Collections.Generic;
using SupportDashboard.Models;

namespace SupportDashboard.Data{

    public class MockRepo : ISupportDashboardRepo
    {
        public IEnumerable<Ticket> GetAllOpenTickets()
        {
            var tickets = new List<Ticket>{
                new Ticket{Id = 1000, Account="KBC",Subject="I have a silly question",Status="Open" },
                new Ticket{Id = 2000, Account="Kempen",Subject="I want to moan",Status="Open" },
                new Ticket{Id = 3000, Account="Cap Group",Subject="Do I have to pay?",Status="Open" }
            };

            return tickets;
        }

        public IEnumerable<TimeStat> GetTimeStats(){
            var timeStats = new List<TimeStat>{
                new TimeStat{userName = "ECE", timeToday = "5", timeWeek = "14"},
                new TimeStat{userName = "LKCN", timeToday = "2", timeWeek = "6"},
                new TimeStat{userName = "CBD", timeToday = "6", timeWeek = "18"},
                new TimeStat{userName = "RSED", timeToday = "5", timeWeek = "10"},
                new TimeStat{userName = "TMHD", timeToday = "3.5", timeWeek = "13"}
            };

            return timeStats;
        }

        public IEnumerable<TimeStatViewModel> GetTimeStatViewModels(){
            //Get Time Stats
            var timeStats = new List<TimeStat>{
                new TimeStat{userName = "ECE", timeToday = "5", timeWeek = "14"},
                new TimeStat{userName = "LKCN", timeToday = "2", timeWeek = "6"},
                new TimeStat{userName = "CBD", timeToday = "6", timeWeek = "18"},
                new TimeStat{userName = "RSED", timeToday = "5", timeWeek = "10"},
                new TimeStat{userName = "TMHD", timeToday = "3.5", timeWeek = "13"}
            };

            //Get ticket info for all users where time was logged in the current week
            var tickets = new List<TimeStatTicket>{
                new TimeStatTicket{UserName = "ECE", Id = 91600, Account="KBC",Subject="I have a silly question",ExecutedTime = "2020-11-16", HoursLogged = 4 },
                new TimeStatTicket{UserName = "ECE", Id = 91790, Account="CAP",Subject="Help for free please",ExecutedTime = "2020-11-17", HoursLogged = 2 },
                new TimeStatTicket{UserName = "CBD", Id = 91600, Account="KBC",Subject="I have a silly question",ExecutedTime = "2020-11-01", HoursLogged = 4 },
                new TimeStatTicket{UserName = "TMHD", Id = 91600, Account="KBC",Subject="I have a silly question",ExecutedTime = "2020-11-01", HoursLogged = 4 },
                new TimeStatTicket{UserName = "RSED", Id = 91600, Account="KBC",Subject="I have a silly question",ExecutedTime = "2020-11-01", HoursLogged = 4 },
                new TimeStatTicket{UserName = "LKCN", Id = 91600, Account="KBC",Subject="I have a silly question",ExecutedTime = "2020-11-01", HoursLogged = 4 },
            };


            //Return view model
            var timeStatViewModels = new List<TimeStatViewModel>{
                new TimeStatViewModel{TimeStats = timeStats,TimeStatTickets = tickets}
            };

            return timeStatViewModels;
        }
    }
}