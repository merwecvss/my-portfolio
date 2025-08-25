using Microsoft.AspNetCore.Mvc;

namespace my_portfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}