using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class FeatureController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}