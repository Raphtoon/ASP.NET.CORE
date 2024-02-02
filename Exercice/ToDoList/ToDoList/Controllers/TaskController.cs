using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {

        private readonly IRepository<TaskToDo> _taskRepository;
        public TaskController(IRepository<TaskToDo> taskRepository)
        {
            _taskRepository = taskRepository;
        }


        // Route => /Task
        public IActionResult Index()
        {
            return View(_taskRepository.GetAll());
        }

        // GET: Task/Details/5
        public IActionResult Details(int id)
        {
            return View(_taskRepository.GetById(id));
        }
        public IActionResult Form(int id)
        {
            if (id == 0) // pas d'id => ADD
                return View();
            // Sinon UPDATE
            var task = _taskRepository.GetById(id);
            return View(task);
        }


        // GET: Task/Create
        public IActionResult SubmitTask(TaskToDo task)
        {
            if (task.Id == 0)
                _taskRepository.Add(task);
            else
                _taskRepository.Update(task);
            return RedirectToAction(nameof(Index));
        }


        // GET: Task/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }
        // GET: Task/Delete/5
        public IActionResult Delete(int id)
        {
            _taskRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
