using Microsoft.EntityFrameworkCore;
using CMP;
using System.Collections.Generic;

namespace CMP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> CustomerDetails { get; set; }

        public DbSet<Country> CountryName { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<State> State { get; set; }
    }
}
