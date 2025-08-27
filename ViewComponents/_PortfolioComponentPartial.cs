using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        DataContext portfolioContext = new DataContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Portfolios.ToList();
            return View(values);
        }
    }
}
