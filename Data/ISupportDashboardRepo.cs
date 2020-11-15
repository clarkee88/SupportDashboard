using System.Collections.Generic;
using SupportDashboard.Models;

namespace SupportDashboard.Data{

    public interface ISupportDashboardRepo
    {
        IEnumerable<Ticket> GetAllOpenTickets();
        IEnumerable<TimeStat> GetTimeStats();
    }
}