using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class GamerDal : IGamerDal
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer account is created successfully");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer account is removed successfully");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer account is updated successfully");
        }
    }
}
