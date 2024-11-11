using Microsoft.AspNetCore.Mvc;
using build_analysis.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace build_analysis.Controllers
{
    public class ToDoController : Controller
    {
        private static List<ToDoItem> _toDoItems = new List<ToDoItem>
        {
            new ToDoItem { Id = 1, Name = "Task 1", IsComplete = false },
            new ToDoItem { Id = 2, Name = "Task 2", IsComplete = true }
        };

        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_toDoItems);
        }

        [HttpPost]
        public IActionResult Create(ToDoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = _toDoItems.Count + 1;
            _toDoItems.Add(item);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(ToDoItem item)
        {
            var existingItem = _toDoItems.Find(i => i.Id == item.Id);
            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = item.Name;
            existingItem.IsComplete = item.IsComplete;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var item = _toDoItems.Find(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            _toDoItems.Remove(item);

            return RedirectToAction("Index");
        }
    }
}