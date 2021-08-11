using GameApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GameApi.Services
{
    public class GameService : IGameService
    {
        private List<Game> _games;
        public GameService()
        {
            /*Given the relative cost of IO vs holding this small list in 
            memory, I chose to hold it in memory*/
            var myJsonString = System.IO.File.ReadAllText("./Services/games.json");
            _games =  JsonConvert.DeserializeObject<List<Game>>(myJsonString);
        }

        public virtual List<Game> Get() => _games;

        public virtual Game Get(int id) => 
            _games.Find(game => game.Id == id);

        public virtual Game Create(Game game){

            _games.Add(game);
            System.IO.File.WriteAllText(@"./Services/games.json", JsonConvert.SerializeObject(_games));
            return game;
        }
    }
}