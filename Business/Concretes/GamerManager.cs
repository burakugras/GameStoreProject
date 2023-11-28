using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class GamerManager : IGamerService
    {
        private IVerificationService _verificationService;
        private IGamerDal _gamerDal;
        public GamerManager(IVerificationService verificationService, IGamerDal gamerDal)
        {
            _verificationService = verificationService;
            _gamerDal = gamerDal;
        }

        public void Add(Gamer gamer)
        {
            if (_verificationService.Verify(gamer))
            {
                _gamerDal.Add(gamer);
            }
            else
            {
                Console.WriteLine("Registration failed");
            }
        }

        public void Delete(Gamer gamer)
        {
            _gamerDal.Delete(gamer);
        }

        public Gamer Get(int id)
        {
            return _gamerDal.Get(g=>g.Id == id);
        }

        public List<Gamer> GetAll()
        {
            return _gamerDal.GetAll();
        }

        public void Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
        }
    }
}
