using gameApi.DTOs;
using gameApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gameApi.Services;
using Serilog;


namespace gameApi.Controllers
{
    [Route("api/manticora")]
    [ApiController]
    public class ManticoraController : ControllerBase
    {

        // Context
        private readonly ApplicationDbContext context;
        public ManticoraController(ApplicationDbContext context)
        {
            this.context = context;
        }


        //
        //[HttpGet]
        //public async Task<ActionResult<ResponseOk<List<ManticoraDto>>>> Get()
        //{
        //    //ResponseOk<List<ManticoraDto>> response = new ResponseOk<List<ManticoraDto>> 
        //    //{

        //    //}
        //    var response = new { mensaje = "Esto es un ejemplo de respuesta OK" };

        //    return Ok(response);
        //}

        //[HttpGet]
        //public async Task<ActionResult<ManticoraDto>> Get()
        //{
        //    await Task.Delay(1000);
        //    var response = new { mensaje = "Esto es un ejemplo de respuesta OK" };
        //    // var manticoraDto = new ManticoraDto { mensaje = "Esto es un ejemplo de respuesta OK" };
        //    return Ok(response);
        //}

        [HttpGet("Status")]
        public async Task<ActionResult<ManticoraDto>> Getmanticora()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);
                ManticoraDto result = new ManticoraDto();
                result = await ManticoraService.CrearManticoraDtoAsincronamente(context);
                return Ok(result);
            }
            catch (Exception e) 
            {
                Log.Error(e,"Process: "+ e.Message);
                return BadRequest(e.Message);
                
            }
             
        }

       



    }
}
