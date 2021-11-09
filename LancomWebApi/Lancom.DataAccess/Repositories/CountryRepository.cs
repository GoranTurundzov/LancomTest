using Lancom.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lancom.DataAccess.Repositories
{
    public class CountryRepository : IRepository<Country>
    {
        private readonly CountryDbContext _context;

        public CountryRepository(CountryDbContext context)
        {
            _context = context;
        }
        public void Add(Country entity)
        {
            if(entity == null)
            {
                throw new NullReferenceException();
            }
            if(_context.Countries.SingleOrDefault(x => x.Name == entity.Name) != null)
            {
                throw new Exception("Country already exists");
            }
            _context.Countries.Add(entity);
            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
           return _context.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.FirstOrDefault(x => x.Id == id);
        }
    }
}
