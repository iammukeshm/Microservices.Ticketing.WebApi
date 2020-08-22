using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Microservice.Models;

namespace Ticketing.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IBus _bus;

        public TicketController(IBus bus)
        {
            _bus = bus;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            Uri uri = new Uri("rabbitmq://localhost/ticket-queue");
            var endPoint = await _bus.GetSendEndpoint(uri);
            await endPoint.Send(ticket);
            return Ok();
        }
    }
}