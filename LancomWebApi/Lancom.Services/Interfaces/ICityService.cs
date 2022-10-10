
using Lancom.Domain;
using Lancom.Models;
using System.Collections.Generic;

namespace Lancom.Services.Interfaces
{
    public interface ICityService
    {
        void AddCity(CityModel city);

        List<CityModel> GetAllCities();

        CityModel GetCityById(int id);

       
    }
}
