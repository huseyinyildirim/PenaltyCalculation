using System.Collections.Generic;
using PenaltyCalculation.Business.Dtos;

namespace PenaltyCalculation.Business.Services
{
    public interface ICountryService
    {
        IEnumerable<CountryDto> GetCountries();
    }
}
