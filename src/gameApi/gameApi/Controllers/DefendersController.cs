using gameApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gameApi.Controllers
{
    [Route("api/defenders")]
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
