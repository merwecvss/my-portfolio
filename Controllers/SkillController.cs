using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class SkillController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}