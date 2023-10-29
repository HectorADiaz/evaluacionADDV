using gameApi.DTOs;
using gameApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gameApi.Services;
using Serilog;
using gameApi.Interfaces;

namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class ManticoraController : ControllerBase
    {

        // Context
        private readonly IManticoraService _manticoraService;
        public ManticoraController(IManticoraService manticoraService)
        {
            _manticoraService = manticoraService;
        }

        [HttpGet("Status")]
        public async Task<ActionResult<ManticoraDto>> StatusManticora()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);
                ManticoraDto result = new ManticoraDto();
                result = await _manticoraService.StatusManticora();
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
                var result = await _manticoraService.GetPosition();
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
