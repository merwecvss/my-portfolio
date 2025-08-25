using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}