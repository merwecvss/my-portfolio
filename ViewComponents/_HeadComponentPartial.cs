using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}