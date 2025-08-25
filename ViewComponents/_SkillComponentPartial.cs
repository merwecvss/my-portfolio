using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        DataContext portfolioContext = new DataContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}