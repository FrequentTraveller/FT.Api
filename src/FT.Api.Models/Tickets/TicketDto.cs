using System;
using System.Collections.Generic;
using System.Text;
using static FT.Api.Models.Enums.TicketEnums;

namespace FT.Api.Models.Tickets
{
    public class TicketDto
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public string AirLineName { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
