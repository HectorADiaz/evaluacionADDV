using gameApi.DTOs;
using gameApi.Interfaces;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // Context
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        [HttpPost("InitGame")]
        public async Task<ActionResult<string>> InitGame()
        {
            try
            {
                Log.Information("Process Call into Init Game" + DateTime.Now);
                bool result = await _gameService.InitGame();
                if (result) {
                    return StatusCode(200, "Proceso Existoso");
                }
                else {
                    return StatusCode(500, "Error en el proceso");
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Process: " + e.Message);
                return BadRequest(e.Message);

            }

        }

        [HttpGet("EndGame")]
        public async Task<ActionResult<GameDto>> EndGame()
        {
            try
            {
                Log.Information("Process Call into EndGame Status " + DateTime.Now);

                GameDto result = new GameDto();
                result = await _gameService.EndGame();
                return Ok(result);
            }
            catch (Exception e)
            {
                Log.Error(e, "Process: " + e.Message);
                return BadRequest(e.Message);

            }

        }

    }
}
