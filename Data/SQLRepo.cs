using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SupportDashboard.Models;
using Dapper;
using System.Linq;

namespace SupportDashboard.Data{

    public class SQLRepo : ISupportDashboardRepo
    {
       
       private readonly IConfiguration _configuration;
        public SQLRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
       
        public IEnumerable<Ticket> GetAllOpenTickets()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeStat> GetTimeStats(){
            throw new NotImplementedException();
        }

        public IEnumerable<TimeStatViewModel> GetTimeStatViewModels(){
            //SQL connection string
            var conStr = _configuration.GetConnectionString("DefaultConnection");
            
            //Get Data
            using (var connection = new SqlConnection(conStr))
                {
                    var timeStats = connection.Query<TimeStat>("Select * from TimeStat").ToList();
                    var tickets = connection.Query<TimeStatTicket>("Select * from TimeStatTicket").ToList();

                    //Return view model
                    var timeStatViewModels = new List<TimeStatViewModel>{
                        new TimeStatViewModel{TimeStats = timeStats,TimeStatTickets = tickets}
                    };

                    return timeStatViewModels;
                }
            
        }
    }
}