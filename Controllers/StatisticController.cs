using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}