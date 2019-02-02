using System;
using System.Collections.Generic;
using System.Text;
using static DFF.Api.Models.Enums.TicketEnums;

namespace DFF.Api.Models.Queries
{
    public class BrowseTickets : PagedQuery
    {
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
        public string AirLineName { get; set; }
        public string CountryDeparture { get; set; }
        public string CountryArrival { get; set; }
        public string CityDeparture { get; set; }
        public string CityArrival { get; set; }
        public Class Class { get; set; }

    }
}
