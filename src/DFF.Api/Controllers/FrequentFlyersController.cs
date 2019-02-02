using DFF.Api.Messages.Commands.FrequentFlyers;
using DFF.Api.Services;
using DFF.Common.RabbitMq;
using DFF.Common.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DFF.Api.Controllers
{
    public class FrequentFlyersController : BaseController
    {
        private readonly IFrequentFlyersService _frequentFlyersService;

        public FrequentFlyersController(IBusPublisher busPublisher,
            IFrequentFlyersService frequentFlyersService) : base(busPublisher)
        {
            _frequentFlyersService = frequentFlyersService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
            => Single(await _frequentFlyersService.GetAsync(id), x => x.Id == UserId || IsAdmin);

        [HttpPost]
        public async Task<IActionResult> Post(CreateFrequentFlyer command)
            => await SendAsync(command.Bind(c => c.Id, UserId),
                resourceId: command.Id, resource: "frequentflyers");
    }
}
