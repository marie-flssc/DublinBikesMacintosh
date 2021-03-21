using System;
using System.Linq;
using DublinBikes_Macintosh.Data;
using DublinBikes_Macintosh.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace topull.Models
{
    public class SeedData
    {
       public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DublinBikesContext(serviceProvider.GetRequiredService<DbContextOptions<DublinBikesContext>>()))
            {
                // Look for any movies.
                if (context.Bikes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bikes.AddRange(
                    new Bikes
                    {
                        Address = "86 Point Road",
                        Latitude = 53.34,
                        Longitude = -53.39,
                        Name = "SMITHFIELD NORTH",
                        Number = 56
                    },

                    new Bikes
                    {
                        Address = "99 Clonmel Street",
                        Latitude = 96.34,
                        Longitude = -6.39,
                        Name = "C STREET",
                        Number = 13
                    },

                    new Bikes
                    {
                        Address = "1bis Hanover Quay",
                        Latitude = 9.00,
                        Longitude = -53.39,
                        Name = "QUAY BIKES",
                        Number = 154
                    },

                    new Bikes
                    {
                        Address = "18 Earl Terrace",
                        Latitude = 29.46,
                        Longitude = -7.18,
                        Name = "EARL TERRACE",
                        Number = 48
                    }
                );
                context.SaveChanges();
            }
        }
     
    }
}