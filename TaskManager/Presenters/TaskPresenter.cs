using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager._Repositories;
using TaskManager.Models;
using TaskManager.Views;

namespace TaskManager.Presenters
{
    public class TaskPresenter
    {
        //Fields
        private ITaskRepository repository;
        private ITaskForm form;
        private BindingSource tasksBindingSource;
        public TaskPresenter(ITaskRepository repository, ITaskForm form)
        {
            this.tasksBindingSource = new BindingSource();
            this.repository = repository;
            this.form = form;

            //subscribe event handler methods to view events
            this.form.AddNewEvent += AddNewTask;

            this.form.Show();
        }

        private void AddNewTask(object? sender, EventArgs e)
        {
            var model = new TaskModel();

            model.Title = form.TaskTitle;
            model.Description = form.TaskDescription;
            model.DueDate = form.TaskDueDate;
            model.Status = false;
            model.Priority = Priority.Medium;
            model.Category = Category.Work;

            try
            {
                repository.Add(model);
                form.Message = "Task is successfully added";
                form.IsSuccessful = true;
                CleanViewFields();

            }
            catch (Exception ex)
            {
                form.IsSuccessful = false;
                form.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            form.TaskTitle = "";
            form.TaskDescription = "";
            form.TaskDueDate = DateTime.UtcNow;
        }




    }
}
