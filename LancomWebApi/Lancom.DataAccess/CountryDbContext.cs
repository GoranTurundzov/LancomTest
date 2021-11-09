using Lancom.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lancom.DataAccess
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions options) : base(options) { }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Slovenia"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Germany"
                    }
                );

            modelBuilder.Entity<City>()
                .HasData(
                    new City
                    {
                        Id = 1,
                        Name = "Ljubljana",
                        CountryId = 1
                    },
                    new City
                    {
                        Id = 2,
                        Name = "Maribor",
                        CountryId = 1
                    },
                    new City
                    {
                        Id = 3,
                        Name = "Koper",
                        CountryId = 1
                    },
                    new City
                    {
                        Id = 4,
                        Name = "Berlin",
                        CountryId = 2
                    },
                    new City
                    {
                        Id = 5,
                        Name = "Munich",
                        CountryId = 2
                    },
                    new City
                    {
                        Id = 6,
                        Name = "Koln",
                        CountryId = 2
                    }
                );

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                        .HasOne(x => x.Country)
                        .WithMany(x => x.Cities)
                        .HasForeignKey(x => x.CountryId);
            Seed(modelBuilder);
        }
    }
}
