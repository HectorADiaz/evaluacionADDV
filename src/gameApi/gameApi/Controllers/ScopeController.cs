using Microsoft.AspNetCore.Mvc;

namespace gameApi.Controllers
{
    [Route("api/scope")]
    [ApiController]
    public class ScopeController : ControllerBase
    {
        // Context
        private readonly ApplicationDbContext context;
        public ScopeController(ApplicationDbContext context)
        {
            this.context = context;
        }

    }
}
