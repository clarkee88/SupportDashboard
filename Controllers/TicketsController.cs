using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SupportDashboard.Models;
using SupportDashboard.Data;

namespace SupportDashboard.Controllers{

    [Route("api/tickets")]
    [ApiController]
    public class TicketsController : ControllerBase{

        private readonly MockRepo _repository = new MockRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Ticket>> GetAllOpenTickets(){
            var ticketItems = _repository.GetAllOpenTickets();
            return Ok(ticketItems);
        }
    }
}