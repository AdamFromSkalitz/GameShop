using GameApi.Models;
using System.Collections.Generic;

namespace GameApi.Services
{
    public interface IGameService{
        
        List<Game> Get();

        Game Get(int id);

        Game Create(Game game);
    }
}