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
    }
}