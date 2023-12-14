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
    public interface IGamerService
    {
        Task<CreatedGamerResponse> Add(CreateGamerRequest createGamerRequest);
        Task<UpdatedGamerResponse> Update(UpdateGamerRequest updateGamerRequest);
        Task<Gamer> Delete(Gamer gamer);
        Task<IPaginate<GetListGamerResponse>> GetAll();
        Task<CreatedGamerResponse> Get(Guid id);
    }
}
