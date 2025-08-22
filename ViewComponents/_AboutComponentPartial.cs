using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}