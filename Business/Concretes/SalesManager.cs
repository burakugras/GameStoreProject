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
            if (game.Offer != null)
            {
                game.Price = game.Price * ((100- game.Offer.Discount)/100);
            }            
            Console.WriteLine($"{game.Name} is purchased by {gamer.FirstName} {gamer.LastName} for {game.Price} dollars");

            //user.OwnedProducts=new List<Product>();
            gamer.OwnedProducts.Add(game);
        }
    }
}
