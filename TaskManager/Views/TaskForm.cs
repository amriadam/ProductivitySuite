using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManager.Views
{
    public partial class TaskForm : Form, ITaskForm
    {
        //Fields
        private string message;
        private bool isSuccessful;


        public TaskForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        //Singelton Pattern(open a single form instance)
        private static TaskForm instance;
        public static TaskForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TaskForm();
            }
            
            return instance;
        }
        public string TaskTitle { 
            get => taskTitleField.Text; 
            set => taskTitleField.Text=value; 
        }
        public string TaskDescription { 
            get => taskDescriptionField.Text; 
            set => taskDescriptionField.Text = value; 
        }
        public DateTime TaskDueDate { 
            get => taskDueDatePicker.Value; 
            set =>  taskDueDatePicker.Value = value; 
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        
        public event EventHandler AddNewEvent;

        private void AssociateAndRaiseViewEvents()
        {
            addTaskButton.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {


                }
                MessageBox.Text = Message;

            };
        }
    }
}
