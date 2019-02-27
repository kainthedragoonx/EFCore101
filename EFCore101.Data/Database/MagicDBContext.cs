using System;
using System.Collections.Generic;
using System.Text;
using EFCore101.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore101.Data.Database
{
    public class MagicDbContext: DbContext
    {
        public MagicDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
