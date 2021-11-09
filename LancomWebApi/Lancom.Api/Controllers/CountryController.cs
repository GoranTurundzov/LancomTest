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
    public class CountryController : ControllerBase
    {
        private ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }


        [HttpGet("GetAllCountries")]
        public ActionResult GetAllCounties()
        {
            return Ok(_countryService.GetAllCounties());
        }
        [HttpPost("AddCountry")]
        public ActionResult CreateCountry([FromBody] CountryModel country)
        {
            try
            {
                if (country != null)
                {
                    _countryService.AddCountry(country);
                    return Ok($"Country {country.Name} added");
                }
                else {
                    return BadRequest("Cannot add empty country");
                    }
            }
            catch(Exception Ex)
            {
                return BadRequest(Ex.Message);      
            }
        }
    }
}
