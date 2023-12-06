using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{

    public class EfCampaignDal : EfEntityRepositoryBase<Campaign, GameStoreDBContext>, ICampaignDal
    {

    }
}
