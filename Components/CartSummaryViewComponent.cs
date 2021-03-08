using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5_IS413.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_5_IS413.Components
{
    public class CartSummaryViewComponent
: ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
