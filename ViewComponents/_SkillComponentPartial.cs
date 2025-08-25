using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}