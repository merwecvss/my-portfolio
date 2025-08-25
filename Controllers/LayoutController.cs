using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}