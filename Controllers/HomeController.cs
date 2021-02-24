using Assignment_5_IS413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5_IS413.Models.ViewModels;
//controller
namespace Assignment_5_IS413.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IFakeAmazonRepository _repository;
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IFakeAmazonRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        //returning the view to show correct stuff on index page
        public IActionResult Index(int page = 1)
        {
            return View(new ProjectListViewModel
            {
                Projects = _repository.Projects
                    .OrderBy(p => p.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Projects.Count()
                }
            });

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
