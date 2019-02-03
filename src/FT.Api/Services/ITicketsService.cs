using FT.Common.Types;
using FT.Api.Models.Queries;
using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FT.Api.Models.Tickets;

namespace FT.Api.Services
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface ITicketsService
    {
        [AllowAnyStatusCode]
        [Get("tickets/{id}")]
        Task<TicketDetailsDto> GetAsync([Path] Guid id);

        [AllowAnyStatusCode]
        [Get("tickets")]
        Task<PagedResult<TicketDto>> BrowseAsync([Query] BrowseTickets query);
    }
}
