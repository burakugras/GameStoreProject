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

        public async Task<Gamer> Delete(Gamer gamer)
        {
            var data = await _gamerDal.GetAsync(g => g.Id == gamer.Id);
            var result = await _gamerDal.DeleteAsync(data, true);
            return result;
        }

        public async Task<CreatedGamerResponse> Get(int id)
        {
            var data = await _gamerDal.GetAsync(g => g.Id == id);
            var result = _mapper.Map<CreatedGamerResponse>(data);
            return result;
        }

        public async Task<IPaginate<GetListGamerResponse>> GetAll()
        {
            var gamerList = await _gamerDal.GetListAsync();
            var responseList = _mapper.Map<Paginate<GetListGamerResponse>>(gamerList);

            return responseList;
        }

        public async Task<UpdatedGamerResponse> Update(UpdateGamerRequest updateGamerRequest)
        {
            var data = await _gamerDal.GetAsync(g => g.Id == updateGamerRequest.Id);
            _mapper.Map(updateGamerRequest, data);

            data.UpdatedDate = DateTime.Now;
            var updatedGame = await _gamerDal.UpdateAsync(data);

            var mappedGamer = _mapper.Map<UpdatedGamerResponse>(updatedGame);
            return mappedGamer;



        }
    }
}
