using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}