using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }

}
