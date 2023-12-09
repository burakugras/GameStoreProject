using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
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
    public class GamerManager : IGamerService
    {

        IGamerDal _gamerDal;
        IMapper _mapper;
        public GamerManager(IGamerDal gamerDal, IMapper mapper)
        {
            _gamerDal = gamerDal;
            _mapper = mapper;
        }

        public async Task<CreatedGamerResponse> Add(CreateGamerRequest createGamerRequest)
        {
            Gamer gamer = _mapper.Map<Gamer>(createGamerRequest);
            Gamer createdGamer = await _gamerDal.AddAsync(gamer);

            CreatedGamerResponse createdGamerResponse = _mapper.Map<CreatedGamerResponse>(createdGamer);

            return createdGamerResponse;
        }

        public Task<CreatedGamerResponse> Delete(CreateGamerRequest createGamerRequest)
        {
            throw new NotImplementedException();
        }

        public Task<CreatedGamerResponse> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IPaginate<GetListGamerResponse>> GetAll()
        {
            var gamerList = await _gamerDal.GetListAsync();
            var responseList = _mapper.Map<Paginate<GetListGamerResponse>>(gamerList);

            return responseList;
        }

        public Task<CreatedGamerResponse> Update(CreateGamerRequest createGamerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
