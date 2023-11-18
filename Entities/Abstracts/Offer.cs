using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public abstract class Offer
    {
        public int Id { get; set; }
        public string? Name{ get; set; }
        public double Discount { get; set; }

    }
}
