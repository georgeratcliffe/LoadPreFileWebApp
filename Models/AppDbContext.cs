using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadPreFileWebApp.Models
{
    ///public class AppDbContext : DbContext
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Employee> Employees { get; set; }
        public DbSet<ResultsLog> ResultsLog { get; set; }
        //public virtual DbSet<string> RunTestProc { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
