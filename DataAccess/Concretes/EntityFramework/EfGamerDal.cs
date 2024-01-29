using Core.DataAccess.EntityFramework;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfGamerDal : EfRepositoryBase<Gamer, int, GameStoreDBContext>, IGamerDal
    {
        GameStoreDBContext _context;
        public EfGamerDal(GameStoreDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
