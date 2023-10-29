using gameApi.DTOs;
using gameApi.Interfaces;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController] 
    public class StockController : ControllerBase
    {

        // Context
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("Article")]
        public async Task<ActionResult<List<StockDto>>> GetStock()
        {
            try
            {
                Log.Information("Process Call into Stock Status " + DateTime.Now);

                List<StockDto> result = new List<StockDto>();
                result = await _stockService.GetStock();
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
