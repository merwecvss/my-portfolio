using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;

namespace my_portfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent 
    {
        DataContext context = new DataContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(XmlConfigurationExtensions => XmlConfigurationExtensions.Status == false).Count();
            var values = context.ToDoLists.Where(XmlConfigurationExtensions => XmlConfigurationExtensions.Status == false).ToList();
            return View(values);
        }
    }
}