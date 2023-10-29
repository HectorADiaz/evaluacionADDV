using gameApi.DTOs;
using gameApi.Interfaces;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class AttackController : ControllerBase
    {

        // Context
        private readonly IAttackService _attackService;

        public AttackController(IAttackService attackService)
        {
            _attackService = attackService;
        }

        [HttpPost("Attack")]
        public async Task<ActionResult<AttackDto>> executeAttack()
        {
            try
            {
                Log.Information("Process Call into Attack " + DateTime.Now);

                AttackDto result = new AttackDto ();
                result = await _attackService.executeAttack();
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
