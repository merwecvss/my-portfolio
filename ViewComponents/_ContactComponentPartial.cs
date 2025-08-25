using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}