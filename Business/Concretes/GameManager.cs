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
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }
        public void Add(Game game)
        {
            _gameDal.Add(game);
        }                

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
        }                

        public Game Get(int id)
        {
            return _gameDal.Get(g=>g.Id == id);
        }

        public List<Game> GetAll()
        {
            return _gameDal.GetAll();
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }

    }
}
