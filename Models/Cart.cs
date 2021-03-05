using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public void AddItem(Project proj, int qty)
        {
            CartLine line = Lines.Where(p => p.project.BookID == proj.BookID)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    project = proj,
                    Quantity = qty

                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public void RemoveLine(Project proj) =>
            Lines.RemoveAll(x => x.project.BookID == proj.BookID);

        public void Clear() => Lines.Clear();

        public double ComputeTotalSum() => Lines.Sum(e => e.project.Price);
         //here is where we conpute the price of the cart
        

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Project project { get; set; }
            public int Quantity { get; set; }

            public double Price { get; set; }

        }
    }
}
