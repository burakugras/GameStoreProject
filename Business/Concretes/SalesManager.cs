using Business.Abstracts;
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
        public void SellGame(Gamer gamer, Game game)
        {
            //if (game.Offer != null)
            //{
            //    decimal discount = (decimal)game.Offer.Discount;
            //    game.Price = game.Price * ((100 - discount ) / 100);
            //}

            ////user.OwnedProducts=new List<Product>();
            //gamer.OwnedProducts.Add(game);
        }
    }
}
