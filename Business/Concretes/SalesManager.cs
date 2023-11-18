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
        public void SellGame(Gamer gamer, Product product)
        {
            if (product.Offer != null)
            {
                product.Price = product.Price * (100- product.Offer.Discount);
            }
            gamer.OwnedProducts.Add(product);
            
            Console.WriteLine($"{product.ProductName} is purchased by {gamer.FirstName} {gamer.LastName} for {product.Price}");
        }
    }
}
