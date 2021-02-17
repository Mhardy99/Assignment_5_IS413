using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{
    public class EFFakeAmazonRepository : IFakeAmazonRepository
    {
        private FakeAmazonDbContext _context;
        //constructor
        public EFFakeAmazonRepository (FakeAmazonDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
