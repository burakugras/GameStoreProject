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
    public class CampaignManager : ICampaignService
    {
        ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal campaignDal) 
        {
            _campaignDal = campaignDal;
        }
        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }
        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
        }

        public List<Campaign> GetAll()
        {
            return _campaignDal.GetAll();
        }

        public Campaign Get(int id)
        {
            return _campaignDal.Get(c=>c.Id == id);
        }
    }
}
