using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Gamer : IEntity
    {
        
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; } = 0; 
        public List<Game> OwnedProducts { get; set; } = new List<Game>();
    }
}
