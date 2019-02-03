using System;
using System.Collections.Generic;
using System.Text;
using static FT.Api.Models.Enums.TicketEnums;

namespace FT.Api.Models.Tickets
{
    public class Ticket
    {
        public Guid Id { get; protected set; }
        public Guid FrequentFlyerId { get; protected set; }
        public Guid FlightId { get; protected set; }
        public Guid AirLineId { get; protected set; }
        public ushort Seat { get; protected set; }
        public Class Class { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
