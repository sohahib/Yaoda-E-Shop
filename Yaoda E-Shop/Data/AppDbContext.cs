using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yaoda_E_Shop.Models;

namespace Yaoda_E_Shop.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<sho>
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Shoes> Sneakers { get; set; }
        //public object Shoes { get; internal set; }
    }
}
