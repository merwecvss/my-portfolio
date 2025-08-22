using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}