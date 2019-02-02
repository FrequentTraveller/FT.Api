using DFF.Common.Types;
using DFF.Api.Models.Orders;
using DFF.Api.Models.Queries;
using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DFF.Api.Models.Tickets;

namespace DFF.Api.Services
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface ITicetsService
    {
        [AllowAnyStatusCode]
        [Get("tickets/{id}")]
        Task<TicketDetailsDto> GetAsync([Path] Guid id);

        [AllowAnyStatusCode]
        [Get("tickets")]
        Task<PagedResult<TicketDto>> BrowseAsync([Query] BrowseTickets query);
    }
}
