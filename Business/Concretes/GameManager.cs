using AutoMapper;
using Business.Abstracts;
using Business.Constants;
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
    public class GameManager : IGameService
    {
        IGameDal _gameDal;
        IMapper _mapper;
        public GameManager(IGameDal gameDal, IMapper mapper)
        {
            _gameDal = gameDal;
            _mapper = mapper;
        }

        public async Task<CreatedGameResponse> Add(CreateGameRequest createGameRequest)
        {
            Game game = _mapper.Map<Game>(createGameRequest);
            Game createdGame = await _gameDal.AddAsync(game);

            CreatedGameResponse createdGameResponse = _mapper.Map<CreatedGameResponse>(createdGame);

            return createdGameResponse;
        }

        public async Task<Game> Delete(Game game)
        {
            var data = await _gameDal.GetAsync(g => g.Id == game.Id);
            var result = await _gameDal.DeleteAsync(data, true);
            return result;
        }

        public async Task<CreatedGameResponse> Get(Guid id)
        {
            var data = await _gameDal.GetAsync(g => g.Id == id);
            var mappedGame = _mapper.Map<CreatedGameResponse>(data);
            return mappedGame;
        }

        /*
        public async Task<Game> Get(Guid id)
        {
            var getGame = await _gameDal.GetAsync(g => g.Id == id);
            //var mappedGame = _mapper.Map<CreatedGameResponse>(getGame);
            return getGame;
        }
        */

        public async Task<IPaginate<GetListGameResponse>> GetAll()
        {
            var gameList = await _gameDal.GetListAsync();
            var responseList = _mapper.Map<Paginate<GetListGameResponse>>(gameList);

            return responseList;
        }

        public async Task<UpdatedGameResponse> Update(UpdateGameRequest updateGameRequest)
        {
            var data = await _gameDal.GetAsync(g => g.Id == updateGameRequest.Id);
            _mapper.Map(updateGameRequest, data);

            data.UpdatedDate = DateTime.Now;
            var updatedGame = await _gameDal.UpdateAsync(data);

            var mappedGame = _mapper.Map<UpdatedGameResponse>(updatedGame);
            return mappedGame;
        }
    }
}
