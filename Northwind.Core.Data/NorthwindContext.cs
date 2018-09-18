using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Data
{
    internal class NorthwindContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

        public NorthwindContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\Northwind_large.sqlite");
        }
    }
}
