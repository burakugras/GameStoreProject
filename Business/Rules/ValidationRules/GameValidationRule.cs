using Business.Constants;
using Business.Dtos.Requests;
using Core.Business;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules.ValidationRules;

public class GameValidationRule : BaseBusinessRules
{
    IGameDal _gameDal;

    public GameValidationRule(IGameDal gameDal)
    {
        _gameDal = gameDal;
    }

    public async Task GameNameCantRepeat(CreateGameRequest createGameRequest)
    {
        var game = await _gameDal.GetAsync(g => g.Name == createGameRequest.Name);
        if (game!=null)
        {
            throw new BusinessException(Messages.GameNameIsExist);
        }
    }

    public async Task PriceCantPassFifty(CreateGameRequest createGameRequest)
    {
        if (createGameRequest.Price>50)
        {
            throw new BusinessException(Messages.PriceLowerThenFifty);
        }
    }

}
