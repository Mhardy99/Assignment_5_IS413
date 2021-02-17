using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{
    public interface IFakeAmazonRepository
    {// creatign an iqueryable object
        IQueryable<Project> Projects { get; }
    }
}
