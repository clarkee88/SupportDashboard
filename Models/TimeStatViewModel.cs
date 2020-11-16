using System.Collections.Generic;

namespace SupportDashboard.Models{

    public class TimeStatViewModel{
        public IEnumerable<TimeStat> TimeStats { get; set; }
        public IEnumerable<TimeStatTicket> TimeStatTickets { get; set; }
    }

}