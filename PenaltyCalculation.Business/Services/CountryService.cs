using System.Collections.Generic;
using System.Linq;
using PenaltyCalculation.Business.Dtos;
using PenaltyCalculation.Data.Repository;

namespace PenaltyCalculation.Business.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IEnumerable<CountryDto> GetCountries()
        {
            var result = _countryRepository.GetAllCountries();

            return result.Select(x => new CountryDto
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();
        }
    }
}
