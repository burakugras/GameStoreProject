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
    public class EfGamerDal : IGamerDal
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer account is created successfully");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer account is removed successfully");
        }

        public Gamer Get(Expression<Func<Gamer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Gamer> GetAll(Expression<Func<Gamer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer account is updated successfully");
        }
    }
}
