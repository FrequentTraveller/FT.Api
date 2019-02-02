using DFF.Api.Framework;
using DFF.Common.RabbitMq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFF.Api.Controllers
{
    [AdminAuth]
    public class TicketsController : BaseController
    {
        private readonly ITicketsService _ticketsService;

        public TicketsController(IBusPublisher busPublisher,
            ITicketsService ticketsService) : base(busPublisher)
        {
            _ticketsService = ticketsService;

        }
    }
}
