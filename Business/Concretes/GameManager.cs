using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }
        public void Add(Product product)
        {
            _gameDal.Add(product);
        }

        public void Delete(Product product)
        {
            _gameDal.Delete(product);
        }

        public void Update(Product product)
        {
            _gameDal.Update(product);
        }
    }
}
