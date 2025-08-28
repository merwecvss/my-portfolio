using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class myPortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}