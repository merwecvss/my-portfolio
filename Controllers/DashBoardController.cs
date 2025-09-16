using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.Controllers
{
    public class DashboardController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            // En yakın 5 yapılacak iş
            var upcomingTasks = context.ToDoLists
                .Where(x => x.Status == false)
                .OrderBy(x => x.Time)
                .Take(5)
                .ToList();

            ViewBag.TaskCount = context.ToDoLists.Count(x => x.Status == false);

            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.ToDoLists.Count();
            ViewBag.v7 = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.v8 = context.ToDoLists.Where(x => x.Status == true).Count();
            return View(upcomingTasks);
        }
    }
}
