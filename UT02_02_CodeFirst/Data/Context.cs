using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UT02_02_CodeFirst.Models;

namespace CodeFirst.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<UT02_02_CodeFirst.Models.Car> Car { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car {
                    Id=1,
                    Model="Panda",
                    Brand="Seat",
                    ReleaseDate=DateTime.Now,
                    Price=15000
                },
                  new Car
                  {
                      Id = 2,
                      Model = "Ibiza",
                      Brand = "Seat",
                      ReleaseDate = DateTime.Now,
                      Price = 16000
                  },
                    new Car
                    {
                        Id = 3,
                        Model = "Franchesco",
                        Brand = "Audi",
                        ReleaseDate = DateTime.Now,
                        Price = 20000
                    }

                );
        }


    }
}
