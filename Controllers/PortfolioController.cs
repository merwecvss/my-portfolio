using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}