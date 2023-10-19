using gameApi.DTOs;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace gameApi.Controllers
{
    public class GameController : ControllerBase
    {
        // Context
        private readonly ApplicationDbContext context;
        public GameController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost("InitGame")]
        public async Task<ActionResult<GameDto>> InitGame()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);

                GameDto result = new GameDto();
                result = await GameService.InitGame(context);
                return Ok(result);
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
                result = await GameService.InitGame(context);
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
