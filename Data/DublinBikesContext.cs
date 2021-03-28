using System;
using Microsoft.EntityFrameworkCore;
using DublinBikes_Macintosh.Models;
using System.Threading.Tasks;

namespace DublinBikes_Macintosh.Data
{
    public class DublinBikesContext : DbContext
    {

        public DublinBikesContext(DbContextOptions<DublinBikesContext> options) : base(options)
        {

        }

        public DbSet<Bikes> Bikes { get; set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
