using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager._Repositories
{
    public interface ITaskRepository
    {
        void Add(TaskModel task);
        void Delete(int taskId);
        void Edit (TaskModel task);
        IEnumerable<TaskModel> GetAll();
        IEnumerable<TaskModel> GetByValue(string value);


    }
}
