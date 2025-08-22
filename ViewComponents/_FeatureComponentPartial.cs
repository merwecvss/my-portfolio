using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}