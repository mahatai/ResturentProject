using Microsoft.EntityFrameworkCore;
using Resturent.Infrastructure.Persistance;
using Resturent.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Infrastructure.Seaders
{
    public class ResturentSeader : IResturentSeader
    {
        private readonly ResturentDbContext _resturentDbContext;
        public ResturentSeader(ResturentDbContext resturentDbContext)
        {
            _resturentDbContext = resturentDbContext;
        }

        public async Task Seed()
        {
            if (_resturentDbContext.Database.GetPendingMigrations().Any())
            {
                await _resturentDbContext.Database.MigrateAsync();
            }

            if (await _resturentDbContext.Database.CanConnectAsync())
            {
                if (!_resturentDbContext.Resturents.Any())
                {
                    var restaurants = GetRestaurants();
                    _resturentDbContext.Resturents.AddRange(restaurants);
                    await _resturentDbContext.SaveChangesAsync();
                }

            }
        }

        private IEnumerable<ResturentProp> GetRestaurants()
        {
            List<ResturentProp> restaurants = [
          new()
            {

                Name = "KFC",
                Category = "Fast Food",
                Description =
                    "KFC (short for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken.",
                ContactEmail = "contact@kfc.com",
                HasDelivery = true,
                Dishes =
                [
                    new ()
                    {
                        Name = "Nashville Hot Chicken",
                        Description = "Nashville Hot Chicken (10 pcs.)",
                        Price = 10.30M,
                    },

                    new ()
                    {
                        Name = "Chicken Nuggets",
                        Description = "Chicken Nuggets (5 pcs.)",
                        Price = 5.30M,
                    },
                ],
                Address = new ()
                {
                    City = "London",
                    Street = "Cork St 5",
                    PostalCode = "WC2N 5DU"
                },

            },
            new ()
            {

                Name = "McDonald",
                Category = "Fast Food",
                Description =
                    "McDonald's Corporation (McDonald's), incorporated on December 21, 1964, operates and franchises McDonald's restaurants.",
                ContactEmail = "contact@mcdonald.com",
                HasDelivery = true,
                Address = new Address()
                {
                    City = "London",
                    Street = "Boots 193",
                    PostalCode = "W1F 8SR"
                }
            },
         
      ];
            return restaurants;
        }
    }
}
