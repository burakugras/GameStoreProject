using Business.Abstracts;
using Business.Constants;
using Core.Utilities;
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
        public IResult Add(Game game)
        {
            _gameDal.Add(game);
            return new SuccessResult(Messages.ProductAdded);
        }                

        public IResult Delete(Game game)
        {
            _gameDal.Delete(game);
            return new SuccessResult(Messages.ProductDeleted);

        }

        public IDataResult<Game> Get(int id)
        {
            return new SuccessDataResult<Game>(_gameDal.Get(g=>g.Id == id));
        }

        public IDataResult<List<Game>> GetAll()
        {
            return new SuccessDataResult<List<Game>>(_gameDal.GetAll(),Messages.ProductsListed);
        }

        public IResult Update(Game game)
        {
            _gameDal.Update(game);
            return new SuccessResult();
        }

    }
}
