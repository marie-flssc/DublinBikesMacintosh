using System;
using Microsoft.EntityFrameworkCore;
using DublinBikes_Macintosh.Models;
namespace DublinBikes_Macintosh.Data
{
    public class DublinBikesContext
    {
        public class MvcMovieContext : DbContext
        {
            public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
            {

            }

            public DbSet<Bikes> Bikes { get; set; }

        }
    }
}
