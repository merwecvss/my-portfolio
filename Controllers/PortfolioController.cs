using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}