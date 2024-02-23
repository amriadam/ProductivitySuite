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
    public class TaskHomePresenter
    {
        //Fields
        private BindingSource tasksBindingSource;
        private ITaskRepository repository;
        private ITaskHomeForm homeForm;
        private IEnumerable<TaskModel> taskList;
        public TaskHomePresenter(ITaskRepository repository, ITaskHomeForm form)
        {
            this.tasksBindingSource = new BindingSource();
            this.repository = repository;
            this.homeForm = form;
            LoadAllTasks();
            this.homeForm.Show();
        }
        private void LoadAllTasks()
        {
            taskList = repository.GetAll();
        }
    }
}
