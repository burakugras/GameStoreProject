using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class GameDal : IGameDal
    {        
        
        public void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName} named product is added to library");
        }

        public void Delete(Product product)
        {
            Console.WriteLine($"{product.ProductName} is removed from library");
        }

        public void Update(Product product)
        {
            Console.WriteLine($"{product.ProductName} named product is updated on library");
        }
    }
}
