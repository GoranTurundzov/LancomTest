using Lancom.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lancom.DataAccess.Repositories
{

    public class CityRepository : IRepository<City>
    {
        private readonly CountryDbContext _context;

        public CityRepository(CountryDbContext context)
        {
            _context = context;
        }
        public void Add(City entity)
        {
            if (entity == null)
            {
                throw new NullReferenceException();
            }
            if (_context.Cities.SingleOrDefault(x => x.Name == entity.Name && x.CountryId == entity.CountryId) != null)
            {
                throw new Exception("A City in that Country already exists");
            }
            _context.Cities.Add(entity);
            _context.SaveChanges();
        }

        public List<City> GetAll() => _context.Cities.Include(x => x.Country).ToList();

        public City GetById(int id)
        {
            return _context.Cities.Include(x => x.Country).FirstOrDefault(x => x.Id == id);
        }
    }
}
