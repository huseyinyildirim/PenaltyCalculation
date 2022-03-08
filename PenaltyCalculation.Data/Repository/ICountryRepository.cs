using System.Collections.Generic;
using PenaltyCalculation.Data.Entities;

namespace PenaltyCalculation.Data.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
    }
}
