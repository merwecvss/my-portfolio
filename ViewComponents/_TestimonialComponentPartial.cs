using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        DataContext portfolioContext = new DataContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Testimonials.ToList();
            return View(values);
        }
    }
}
