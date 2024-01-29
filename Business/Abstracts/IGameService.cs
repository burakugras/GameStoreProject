using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Core.Utilities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGameService
    {
        Task<CreatedGameResponse> Add(CreateGameRequest createGameRequest);
        Task<UpdatedGameResponse> Update(UpdateGameRequest updateGameRequest);
        Task<Game> Delete(Game game);
        Task<IPaginate<GetListGameResponse>> GetAll();
        Task<CreatedGameResponse> Get(int id);

    }
}
