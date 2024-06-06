using EncantoPaisa.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EncantoPaisa.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Entities.Events> Events { get; set; }
        public DbSet<Entities.Hotels> Hotels { get; set; }
        public DbSet<Entities.Restaurants> Restaurants { get; set; }
    }
}



