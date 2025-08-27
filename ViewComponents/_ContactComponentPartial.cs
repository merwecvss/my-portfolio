using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        DataContext portfolioContext = new DataContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Contacts.ToList();
            return View(values);
        }
        // Bu alana form işleminde yapılan get post işlemi yazılacak.
    }
}