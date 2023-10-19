using gameApi.DTOs;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

namespace gameApi.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {

        // Context
        private readonly ApplicationDbContext context;
        public StockController(ApplicationDbContext context)
        {
            this.context = context;
        }




        [HttpGet("Art")]
        public async Task<ActionResult<List<StockDto>>> GetStock()
        {
            try
            {
                Log.Information("Process Call into manticora Status " + DateTime.Now);

                List<StockDto> result = new List<StockDto>();
                result = await StockService.GetStock(context);
                return Ok(result);
            }
            catch (Exception e)
            {
                Log.Error(e, "Process: " + e.Message);
                return BadRequest(e.Message);

            }

        }
    }
