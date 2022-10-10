using Lancom.DataAccess;
using Lancom.Domain;
using Lancom.Models;
using Lancom.Services.Interfaces;
using System;
using System.Collections.Generic;
using Lancom.Services.Mappers;
using System.Text;

namespace Lancom.Services.Implementation
{
    class CityService : ICityService
    {
        private readonly IRepository<City> _cityRepository;
   
        public CityService(IRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public void AddCity(CityModel city)
        {
            _cityRepository.Add(city.ToCity());
        }

        public List<CityModel> GetAllCities()
        {

            List<CityModel> cities = new List<CityModel>();
            foreach(City city in _cityRepository.GetAll())
            {
                cities.Add(city.ToCityModel());
            }
            return cities;
        }

        public CityModel GetCityById(int id)
        {
            return _cityRepository.GetById(id).ToCityModel();
        }
    }
}
