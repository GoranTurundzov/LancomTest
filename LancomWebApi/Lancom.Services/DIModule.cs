using Lancom.DataAccess;
using Lancom.DataAccess.Repositories;
using Lancom.Domain;
using Lancom.Services.Implementation;
using Lancom.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lancom.Services
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services , string connectionString)
        {
            services.AddDbContext<CountryDbContext>(x => x.UseSqlServer(connectionString));

            services.AddTransient<IRepository<Country>, CountryRepository>();
            services.AddTransient<IRepository<City>, CityRepository>();

            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICountryService, CountryService>();

            return services;
        }
    }
}
