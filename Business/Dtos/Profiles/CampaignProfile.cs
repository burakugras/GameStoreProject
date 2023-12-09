using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Profiles
{
    public class CampaignProfile : Profile
    {
        public CampaignProfile()
        {
            CreateMap<CreateCampaignRequest, Campaign>();
            CreateMap<Campaign, CreatedCampaignResponse>();

            CreateMap<Campaign, GetListCampaignResponse>().ReverseMap();
            CreateMap<Paginate<Campaign>, Paginate<GetListCampaignResponse>>().ReverseMap();
        }
    }
}
