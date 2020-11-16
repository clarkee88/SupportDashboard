using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SupportDashboard.Models;
using SupportDashboard.Data;

namespace SupportDashboard.Controllers{

    [Route("api/timestats")]
    [ApiController]
    public class TimeStatsController : ControllerBase{

        private readonly ISupportDashboardRepo _repository;

        public TimeStatsController(ISupportDashboardRepo repository)
        {
           _repository = repository; 
        }

        // [HttpGet]
        // public ActionResult <IEnumerable<TimeStat>> GetTimeStats(){
        //     var timeStats = _repository.GetTimeStats();
        //     return Ok(timeStats);
        // }
    [HttpGet]
    public ActionResult <IEnumerable<TimeStatViewModel>> GetTimeStatViewModels(){
            var timeStats = _repository.GetTimeStatViewModels();
            return Ok(timeStats);
        }


    }
}