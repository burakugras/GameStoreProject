using Business.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SalesManager : ISalesService
    {
        public void SellGame(User user, Product product)
        {
            if (product.Offer != null)
            {
                product.Price = product.Price * ((100- product.Offer.Discount)/100);
            }            
            Console.WriteLine($"{product.ProductName} is purchased by {user.FirstName} {user.LastName} for {product.Price} dollars");

            //user.OwnedProducts=new List<Product>();
            user.OwnedProducts.Add(product);
        }
    }
}
