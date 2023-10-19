using Microsoft.AspNetCore.Mvc;

namespace gameApi.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
