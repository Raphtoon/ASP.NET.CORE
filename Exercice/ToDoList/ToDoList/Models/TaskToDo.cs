using System.ComponentModel.DataAnnotations;
using ToDoList.Enums;
namespace ToDoList.Models
{
    public class TaskToDo
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Titre de la tâche")]
        [EnumDataType(typeof(TitleEnum))]
        public TitleEnum Title { get; set; }
        [Display(Name = "Description de la tâche")]
        public string? Description { get; set; }
        [Display(Name = "Actions")]
        public bool? StatutTask { get; set; }
    }
}
