using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
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
        Task<CreatedCampaignResponse> Add(CreateCampaignRequest createCampaignRequest);
        Task<UpdatedCampaignResponse> Update(UpdateCampaignRequest updateCampaignRequest);
        Task<Campaign> Delete(Campaign campaign);
        Task<IPaginate<GetListCampaignResponse>> GetAll();
        Task<CreatedCampaignResponse> Get(Guid id);

    }
}
