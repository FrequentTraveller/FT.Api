using FT.Api.Models.FrequentFlyers;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FT.Api.Services
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface IFrequentFlyersService
    {
        [AllowAnyStatusCode]
        [Get("frequentflyers/{id}")]
        Task<FrequentFlyer> GetAsync([Path] Guid id);
    }
}
