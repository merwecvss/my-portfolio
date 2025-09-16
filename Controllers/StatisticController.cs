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
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.ToDoLists.Count();
            ViewBag.v7 = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.v8 = context.ToDoLists.Where(x => x.Status == true).Count();
            return View();
        }
    }
}