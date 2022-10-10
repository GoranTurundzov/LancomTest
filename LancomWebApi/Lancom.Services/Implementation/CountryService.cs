using Lancom.DataAccess;
using Lancom.Domain;
using Lancom.Models;
using Lancom.Services.Interfaces;
using Lancom.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lancom.Services.Implementation
{
    public class CountryService : ICountryService
    {

        private readonly IRepository<Country> _countryRepository;
        private readonly IRepository<City> _cityRepository;

        public CountryService(IRepository<Country> countryRepository , IRepository<City> cityRepository)
        {
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
        }
        public void AddCountry(CountryModel country)
        {
            _countryRepository.Add(country.ToCountry());
        }

        public List<CountryModel> GetAllCounties()
        {
            List<Country> countries = _countryRepository.GetAll();
            List<CountryModel> cModels = new List<CountryModel>();
            foreach(Country coun in countries)
            {
                cModels.Add(coun.ToCountryModel());
            }
            return cModels;
        }

        public List<CityModel> GetCitiesInACountry(int countryId)
        {
            List<CityModel> cityModels = new List<CityModel>();
            List<City> cities = _cityRepository.GetAll().Where(x => x.CountryId == countryId).ToList();
            foreach(City city in cities)
            {
                cityModels.Add(city.ToCityModel());
            }

            return cityModels;
        }

        public CountryModel GetCountryById(int id)
        {
            return _countryRepository.GetById(id).ToCountryModel();
        }
    }
}
