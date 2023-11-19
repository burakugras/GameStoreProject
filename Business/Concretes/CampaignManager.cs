using Business.Abstracts;
using Entities.Abstracts;
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
        public void AddCampaign(Product product, Offer offer)
        {
            product.Offer = offer;
            Console.WriteLine($"Campaign {offer.Name} added for {product.ProductName}");
        }
        public void UpdateCampaign(Product product, Offer offer)
        {
            Console.WriteLine($"Campaign {offer.Name} updated for {product.ProductName}");
        }

        public void DeleteCampaign(Product product, Offer offer)
        {
            product.Offer = null;
        }

    }
}
