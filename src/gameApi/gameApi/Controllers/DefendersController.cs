using gameApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace gameApi.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class DefendersController : ControllerBase
    {
        // Context
        private readonly ApplicationDbContext context;
        public DefendersController(ApplicationDbContext context) { 
            this.context = context;
        }


        // GET: api/<DefendersController>
        [HttpGet]
        public async Task<ActionResult<List<Defender>>> Get()
        {
            return await context.defenders.ToListAsync();
        }

    }
}
