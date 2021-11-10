using Lancom.Domain;
using Lancom.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lancom.Services.Mappers
{
    public static class CityMapper
    {
        
        public static CityModel ToCityModel(this City city)
        {
            return new CityModel
            {
                Id = city.Id,
                Name = city.Name,
                CountryId = city.CountryId,
                Country = city.Country.Name
            };
        }

        public static City ToCity(this CityModel city)
        {
            return new City
            {
                Id = city.Id,
                Name = city.Name,
                CountryId = city.CountryId
            };
        }
    }
}
