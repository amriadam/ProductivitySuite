using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public enum Priority
    {
        High,
        Medium,
        Low
    }

    public enum Category
    {
        Work,
        Personal,
        errands
    }

    public class TaskModel
    {
        private int id;
        private string title;
        private string description;
        private DateTime dueDate;
        private bool status;
        private Priority priority;
        private Category category;


        [DisplayName("Task ID")]
        public int Id { get => id; set => id = value; }


        [DisplayName("Task Title")]
        [Required (ErrorMessage ="Task title is required")]
        public string Title { get => title; set => title = value; }

        
        [DisplayName("Task Description")]
        public string Description { get => description; set => description = value; }

        
        [DisplayName("Task Due Date")]
        [Required(ErrorMessage = "Task due date is required")]
        public DateTime DueDate { get => dueDate; set => dueDate = value; }

        
        [DisplayName("Task Status")]
        [Required(ErrorMessage = "Task status is required")]
        public bool Status { get => status; set => status = value; }


        [DisplayName("Task Priority")]
        [Required(ErrorMessage = "Task priority is required")]
        public Priority Priority { get => priority; set => priority = value; }


        [DisplayName("Task Category")]
        [Required(ErrorMessage = "Task category is required")]
        public Category Category { get => category; set => category = value; }
    }
}
