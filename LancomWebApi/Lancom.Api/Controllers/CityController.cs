using Lancom.Models;
using Lancom.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lancom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityService _cityService;
        private ICountryService _countryService;

        public CityController(ICityService cityService, ICountryService countryService)
        {
            _cityService = cityService;
            _countryService = countryService;
        }

        [HttpGet("GetAllCities")]
        public ActionResult<List<CityModel>> GetAll()
        {
            List<CityModel> cities = _cityService.GetAllCities();
            if (cities.Any())
            {
                return Ok(cities);
            } else
            {
                return NoContent();
            }
        }

        [HttpPost()] 
        public ActionResult CreateCityFromBody([FromBody] CityModel city)
        {
            if(!_countryService.GetAllCounties().Select(x => x.Id).ToList().Any(x => x == city.CountryId)) 
            {
                return BadRequest("No country with that ID");
            }
            List<CityModel> cities = _cityService.GetAllCities();
            if(!cities.Any(x => x.Name == city.Name && x.CountryId == city.CountryId))
            {
                _cityService.AddCity(city);
                return Ok($"{city.Name} added");
            }
            else
            {
                return BadRequest("City with that name in that country already exists");
            }
        }
        public ActionResult CreateCityFromQuery([FromQuery] CityModel city)
        {
            if (!_countryService.GetAllCounties().Select(x => x.Id).ToList().Any(x => x == city.CountryId))
            {
                return BadRequest("No country with that ID");
            }
            List<CityModel> cities = _cityService.GetAllCities();
            if (!cities.Any(x => x.Name == city.Name && x.CountryId == city.CountryId))
            {
                _cityService.AddCity(city);
                return Ok($"{city.Name} added");
            }
            else
            {
                return BadRequest("City with that name in that country already exists");
            }
        }
    }
}
