using System;
using System.Collections.Generic;
using PenaltyCalculation.Data.Entities;

namespace PenaltyCalculation.Data.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {

        public CountryRepository(AppDbContext context) : base(context)
        {

        }
        public IEnumerable<Country> GetAllCountries()
        {
            return FindAll();
        }
    }
}
