using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DominionGameGenerator.Services;
using DominionGameGenerator.Services.DataTransferObjects;
using DominionGameGenerator.Web.Models;

namespace DominionGameGenerator.Web.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] GameParametersDto gameParameters)
        {
            return ApiResult<GameDto>.GetSingle(_gameService.GetGame(gameParameters));
        }
    }
}
