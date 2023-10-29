using gameApi.DTOs;
using gameApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gameApi.Services;
using Serilog;


namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class ManticoraController : ControllerBase
    {

        // Context
        private readonly ApplicationDbContext context;
        public ManticoraController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("Status")]
        public async Task<ActionResult<ManticoraDto>> StatusManticora()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);
                ManticoraDto result = new ManticoraDto();
                result = await ManticoraService.StatusManticora(context);
                return Ok(result);
            }
            catch (Exception e) 
            {
                Log.Error(e,"Process: "+ e.Message);
                return BadRequest(e.Message);
                
            }     
        }

        [HttpGet("Position")]
        public async Task<ActionResult<ManticoraDto>> GetPosition()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);
               // ManticoraDto result = new ManticoraDto();
                var result = await ManticoraService.GetPosition(context);
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
