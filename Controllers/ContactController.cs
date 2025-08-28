using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class ContactController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}