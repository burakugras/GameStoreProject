using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class CampaignManager : ICampaignService
    {
        public void AddCampaign(Game game, Campaign campaign)
        {
            game.Offer = campaign;
            Console.WriteLine($"Campaign {campaign.Name} added for {game.ProductName}");
        }
        public void UpdateCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine($"Campaign {campaign.Name} updated for {game.ProductName}");
        }

        public void DeleteCampaign(Game game, Campaign campaign)
        {
            game.Offer = null;
        }

    }
}
