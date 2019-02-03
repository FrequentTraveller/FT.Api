using FT.Api.Models.Tickets;
using FT.Common.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FT.Api.Models.Enums.FrequentFlyerEnums;

namespace FT.Api.Messages.Commands.FrequentFlyers
{
    [MessageNamespace("frequentflyers")]
    public class CreateFrequentFlyer : ICommand
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get;  }
        public string Country { get; }
        public int MilesInAir { get; }
        public FrequentFlyerStatus Status { get; }
        public IEnumerable<Ticket> Tickets { get; }

        [JsonConstructor]
        public CreateFrequentFlyer(string firstName, string lastName, string address, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Country = country;
            Status = FrequentFlyerStatus.NotFF;
            MilesInAir = 0;
            Tickets = new HashSet<Ticket>();
        }
    }
}
