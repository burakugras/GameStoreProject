using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Core.Utilities;
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

        public Task<CreatedCampaignResponse> Delete(CreateCampaignRequest createCampaignRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<CreatedCampaignResponse> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IPaginate<GetListCampaignResponse>> GetAll()
        {
            var campaignList = await _campaignDal.GetListAsync();
            var responseList=_mapper.Map<Paginate<GetListCampaignResponse>>(campaignList);

            return responseList;
        }

        public Task<CreatedCampaignResponse> Update(CreateCampaignRequest createCampaignRequest)
        {
            throw new NotImplementedException();
        }
    }
}
