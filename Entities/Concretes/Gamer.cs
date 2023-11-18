using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Gamer : User
    {
        private double _balance;
        public Gamer()
        {
            _balance = 0;
        }

        //balance'ı dönmek için CurrentBalance prop'unu kullandık
        public double CurrentBalance { get { return _balance; } }

        public void AddBalance(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine("Balance updated. New balance: "+_balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
        }

        public override double Balance { get { return _balance; } }

        public string? TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
