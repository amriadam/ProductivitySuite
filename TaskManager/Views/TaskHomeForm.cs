using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Views.Controls;

namespace TaskManager.Views
{
    public partial class TaskHomeForm : Form,ITaskHomeForm
    {
        private int initialY = 10;


        public TaskHomeForm()
        {

            InitializeComponent();

            // Set the FlowLayoutPanel properties
            ToDoGroupBox.Controls.Add(new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            });

            for (int i = 0; i < 3; i++)
            {
                TaskCard newTaskCard = new TaskCard();
                newTaskCard.Location = new Point(10, initialY + i * (newTaskCard.Height + 5));

                ((FlowLayoutPanel)ToDoGroupBox.Controls[0]).Controls.Add(newTaskCard);

            }
        }
    }
}
