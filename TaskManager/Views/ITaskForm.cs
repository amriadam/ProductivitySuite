using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Views
{
    public interface ITaskForm
    {
        string TaskTitle { get; set; }

        string TaskDescription { get; set; }

        DateTime TaskDueDate { get; set; }


        event EventHandler AddNewEvent;

        bool IsSuccessful { get; set; }
        string Message { get; set; }
        void Show();



    }
}
