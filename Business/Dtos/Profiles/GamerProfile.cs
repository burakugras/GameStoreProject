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
    public class GamerProfile : Profile
    {
        public GamerProfile()
        {
            CreateMap<CreateGamerRequest, Gamer>();
            CreateMap<Gamer, CreatedGamerResponse>();

            CreateMap<Gamer, GetListGamerResponse>().ReverseMap();
            CreateMap<Paginate<Gamer>, Paginate<GetListGamerResponse>>().ReverseMap();

            CreateMap<UpdateGamerRequest, Gamer>();
            CreateMap<Gamer, UpdatedGamerResponse>();
        }
    }
}
