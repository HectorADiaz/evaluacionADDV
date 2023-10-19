using Microsoft.AspNetCore.Mvc;

namespace gameApi.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
