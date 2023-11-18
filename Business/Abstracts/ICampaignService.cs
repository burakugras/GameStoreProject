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
        void AddCampaign(Game game, Campaign campaign);
        void UpdateCampaign(Game game, Campaign campaign);
        void DeleteCampaign(Game game, Campaign campaign);

    }
}
