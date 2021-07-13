using Microsoft.EntityFrameworkCore;
using Recruiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruiter.DataContext
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options)
        {
                
        }

        public DbSet<Package> Packages { get; set; }
    }
}
