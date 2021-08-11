using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GameApi.Models;
using GameApi.Services;

namespace GameApi.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService){
            _gameService = gameService;
        }

        [HttpGet]
        public ActionResult<List<GameDto>> Get() => 
            _gameService.Get().Select(x => GameToDto(x)).ToList();

        [HttpGet("{id}")]
        public ActionResult<Game> Get(int id)
        {
            var game = _gameService.Get(id);
            if(game == null){
                return NotFound();
            }
            return game;
        }

        [HttpPost]
        public ActionResult<Game> Create(Game game)
        {
             var createdGame = _gameService.Create(game);
             return CreatedAtRoute("GetGame", new {id = game.Id.ToString()}, game);
        }

        private GameDto GameToDto(Game game) =>
            new GameDto
            {
                Id = game.Id,
                Title = game.Title
            };
    }
}