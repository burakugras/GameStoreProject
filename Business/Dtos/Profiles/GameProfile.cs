﻿using AutoMapper;
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
    public class GameProfile:Profile
    {
        public GameProfile()
        {
            CreateMap<CreateGameRequest, Game>();
            CreateMap<Game, CreatedGameResponse>();

            CreateMap<Game, GetListGameResponse>().ReverseMap();
            CreateMap<Paginate<Game>, Paginate<GetListGameResponse>>().ReverseMap();

            CreateMap<UpdateGameRequest, Game>();
            CreateMap<Game, UpdatedGameResponse>();
        }
    }
}
