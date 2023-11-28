using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfGameDal : IGameDal
    {

        public void Add(Game game)
        {
            Console.WriteLine($"{game.Name} named product is added to library");
        }

        public void Delete(Game game)
        {
            Console.WriteLine($"{game.Name} is removed from library");
        }

        public Game Get(Expression<Func<Game, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll(Expression<Func<Game, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.Name} named product is updated on library");
        }
    }
}
