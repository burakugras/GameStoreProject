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

    public class EfCampaignDal : EfRepositoryBase<Campaign, int, GameStoreDBContext>, ICampaignDal
    {
        GameStoreDBContext _context;
        public EfCampaignDal(GameStoreDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
