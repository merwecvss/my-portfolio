using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}