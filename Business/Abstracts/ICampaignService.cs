using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICampaignService
    {
        void AddCampaign(Product product, Offer offer);
        void UpdateCampaign(Product product, Offer offer);
        void DeleteCampaign(Product product, Offer offer);

    }
}
