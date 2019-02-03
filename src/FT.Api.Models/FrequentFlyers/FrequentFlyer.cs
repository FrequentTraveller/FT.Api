using FT.Api.Models.Tickets;
using System;
using System.Collections.Generic;
using System.Text;
using static FT.Api.Models.Enums.FrequentFlyerEnums;

namespace FT.Api.Models.FrequentFlyers
{
    public class FrequentFlyer
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set;  }
        public string Country { get; set;  }
        public int MilesInAir { get; set; }
        public FrequentFlyerStatus Status { get; set; }
        public bool Completed => CompletedAt.HasValue;
        public DateTime? CompletedAt { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Deleted { get; set; }

    }
}
