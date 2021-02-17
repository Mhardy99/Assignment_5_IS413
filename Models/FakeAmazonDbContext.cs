using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{//creating a new class and passing it DbContext
    public class FakeAmazonDbContext : DbContext
    {
        public FakeAmazonDbContext (DbContextOptions<FakeAmazonDbContext> options) : base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }

    }
}
