using FT.Api.Framework;
using FT.Api.Services;
using FT.Common.RabbitMq;

namespace FT.Api.Controllers
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
