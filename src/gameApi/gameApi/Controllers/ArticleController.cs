using gameApi.DTOs;
using gameApi.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

namespace gameApi.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        // Context
        private readonly ApplicationDbContext context;
        public ArticleController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("Articles")]
        public async Task<ActionResult<List<ArticleDto>>> GetArticles()
        {
            try
            {
                Log.Information("Process Call into Articles Status " + DateTime.Now);

                List<ArticleDto> result = new List<ArticleDto>();
                result = await ArticleService.GetArticles(context);
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
