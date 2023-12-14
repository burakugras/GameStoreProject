using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Core.Utilities;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
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
        IMapper _mapper;
        public CampaignManager(ICampaignDal campaignDal,IMapper mapper) 
        {
            _campaignDal = campaignDal;
            _mapper = mapper;
        }

        public async Task<CreatedCampaignResponse> Add(CreateCampaignRequest createCampaignRequest)
        {
            Campaign campaign = _mapper.Map<Campaign>(createCampaignRequest);
            Campaign createdCampaign=await _campaignDal.AddAsync(campaign);

            CreatedCampaignResponse createdCampaignResponse=_mapper.Map<CreatedCampaignResponse>(createdCampaign);

            return createdCampaignResponse;
        }

        public async Task<Campaign> Delete(Campaign campaign)
        {
            var data = await _campaignDal.GetAsync(c => c.Id == campaign.Id);
            var result = await _campaignDal.DeleteAsync(data, true);
            return result;
        }

        public async Task<CreatedCampaignResponse> Get(Guid id)
        {
            var data= await _campaignDal.GetAsync(c=>c.Id == id);
            var mappedCampaign=_mapper.Map<CreatedCampaignResponse>(data);
            return mappedCampaign;
        }

        public async Task<IPaginate<GetListCampaignResponse>> GetAll()
        {
            var campaignList = await _campaignDal.GetListAsync();
            var responseList=_mapper.Map<Paginate<GetListCampaignResponse>>(campaignList);

            return responseList;
        }

        public async Task<UpdatedCampaignResponse> Update(UpdateCampaignRequest updateCampaignRequest)
        {
            var data = await _campaignDal.GetAsync(c => c.Id == updateCampaignRequest.Id);
            _mapper.Map(updateCampaignRequest, data);

            data.UpdatedDate = DateTime.Now;
            var updatedCampaign = await _campaignDal.UpdateAsync(data);

            var mappedCampaign = _mapper.Map<UpdatedCampaignResponse>(updatedCampaign);
            return mappedCampaign;
        }
    }
}
