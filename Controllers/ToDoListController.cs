using Microsoft.AspNetCore.Mvc;
using my_portfolio.Models.Context;
using my_portfolio.Models.Entities;

namespace my_portfolio.Controllers
{
    public class ToDoListController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ChangeToDoListStatus(int id, bool status)
        {
            var value = context.ToDoLists.Find(id);
            if (value != null)
            {
                value.Status = status;
                context.SaveChanges();
            }
            return Ok();
        }

    }
}