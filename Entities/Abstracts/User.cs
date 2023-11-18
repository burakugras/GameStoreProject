using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public abstract class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public abstract double Balance { get; }
        public List<Product> OwnedProducts { get; set; }=new List<Product>();
    }
}
