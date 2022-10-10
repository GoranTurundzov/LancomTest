using Lancom.Models;
using System.Collections.Generic;

namespace Lancom.Services.Interfaces
{
    public interface ICountryService
    {
        List<CityModel> GetCitiesInACountry(int countryId);

        List<CountryModel> GetAllCounties();
        CountryModel GetCountryById(int id);

        void AddCountry(CountryModel country);
    }
}
