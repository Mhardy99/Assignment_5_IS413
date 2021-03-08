using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5_IS413.Infrastructure;
using Assignment_5_IS413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Assignment_5_IS413.Pages
{
    public class DonateModel : PageModel
    {
        private IFakeAmazonRepository repository;

        public DonateModel(IFakeAmazonRepository repo)
        {
            repository = repo;
        }
        //properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long BookID, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(p => p.BookID == BookID);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long bookID, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.project.BookID == bookID).project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
