using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class AboutController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}