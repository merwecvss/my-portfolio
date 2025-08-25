using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}