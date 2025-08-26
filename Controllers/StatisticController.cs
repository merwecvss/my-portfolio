using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.Controllers
{
    public class StatisticController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}