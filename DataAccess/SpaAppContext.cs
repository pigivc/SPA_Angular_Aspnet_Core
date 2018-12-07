using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SpaAppContext : DbContext
    {
        public SpaAppContext()
        { }

        public SpaAppContext(DbContextOptions<SpaAppContext> options)
        : base(options) { }

        public static SpaAppContext CreateContext()
        {
            return new SpaAppContext();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}

        public DbSet<Movie> Movies { get; set; }
    }
}
