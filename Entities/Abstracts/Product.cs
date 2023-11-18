using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int UnitInStock { get; set; }
        public Offer? Offer { get; set; }
    }
}
