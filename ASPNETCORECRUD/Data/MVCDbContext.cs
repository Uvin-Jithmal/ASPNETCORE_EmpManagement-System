using ASPNETCORECRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Bridge between entity framwork core and the database
namespace ASPNETCORECRUD.Data
{
    public class MVCDbContext : DbContext
    {
        //constructor
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
