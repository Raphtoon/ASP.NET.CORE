using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ToDoList.Enums;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TaskToDo> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskToDo>().HasData(
                new TaskToDo { Id = 1, Title = TitleEnum.Rangement, Description = "Faut ranger", StatutTask = false },
                new TaskToDo { Id = 2, Title = TitleEnum.Nettoyage, Description = "Laver la chambre des enfants", StatutTask = false },
                new TaskToDo { Id = 3, Title = TitleEnum.Cuisine, Description = "Faire à manger", StatutTask = false },
                new TaskToDo { Id = 4, Title = TitleEnum.Animaux, Description = "Promener les chiens", StatutTask = false },
                new TaskToDo { Id = 5, Title = TitleEnum.Travail, Description = "Visio avec l'équipe à 20h00", StatutTask = false }
            );
        }
    }
}
