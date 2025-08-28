using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}