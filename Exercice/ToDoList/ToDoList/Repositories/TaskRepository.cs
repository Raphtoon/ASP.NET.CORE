using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class TaskRepository : IRepository<TaskToDo> 
    {
        private readonly ApplicationDbContext _dbContext;

        public TaskRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Add(TaskToDo tache)
        {
            _dbContext.Tasks.Add(tache);
            _dbContext.SaveChanges();
            return true;
        }

        public List<TaskToDo> GetAll()
        {
            return _dbContext.Tasks.ToList();
        }
        public TaskToDo? GetById(int id)
        {
            return _dbContext.Tasks.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(TaskToDo task)
        {
            var taskFromDb = GetById(task.Id);

            if (taskFromDb == null)
                return false;

            taskFromDb.Title = task.Title;
            taskFromDb.Description = task.Description;
            taskFromDb.StatutTask = task.StatutTask;

            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            var task = GetById(id);

            if (task == null)
                return false;

            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();

            return true;
        }
        public List<TaskToDo> GetAll(Expression<Func<TaskToDo, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
