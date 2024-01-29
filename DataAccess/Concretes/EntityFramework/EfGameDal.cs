﻿using Core.DataAccess.EntityFramework;
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
    public class EfGameDal : EfRepositoryBase<Game, int, GameStoreDBContext>, IGameDal
    {
        GameStoreDBContext _context;
        public EfGameDal(GameStoreDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
