using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturent.Models.Entities;

namespace Resturent.Infrastructure.Persistance
{
    public class ResturentDbContext : DbContext
    {
        public ResturentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ResturentProp> Resturents { get; set; }
        public DbSet<Dish> Dishes { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ResturentProp>().OwnsOne(r => r.Address);
            modelBuilder.Entity<ResturentProp>().HasMany(r => r.Dishes).WithOne().HasForeignKey(d => d.ResturentId);
        }

    }
}
