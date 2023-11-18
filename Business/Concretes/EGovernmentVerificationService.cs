using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
     public class EGovernmentVerificationService : IVerificationService
    {
        public bool Verify(Gamer gamer)
        {
            return gamer.TcNo.Length == 11 && (2023 - (gamer.BirthYear)) > 18;
        }
    }
}
