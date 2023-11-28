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
    public class EfCampaignDal : ICampaignDal
    {
        public void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public Campaign Get(Expression<Func<Campaign, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetAll(Expression<Func<Campaign, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
