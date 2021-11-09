using Lancom.Domain;
using Lancom.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lancom.Services.Mappers
{
    public static class CountryMapper
    {

       public static Country ToCountry(this CountryModel country)
        {
            Country newCountry = new Country
            {
                Id = country.Id,
                Name = country.Name,
                Cities = new List<City>()
            };
            

            return newCountry;
        }

        public static CountryModel ToCountryModel(this Country country)
        {
            CountryModel countryModel = new CountryModel
            {
                Id = country.Id,
                Name = country.Name
            };
           
            return countryModel;
        }
    }
}
