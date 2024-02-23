namespace TaskManager.Views
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskDescriptionField = new RichTextBox();
            taskTitleField = new TextBox();
            taskDueDatePicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            addTaskButton = new Button();
            label1 = new Label();
            MessageBox = new Label();
            SuspendLayout();
            // 
            // taskDescriptionField
            // 
            taskDescriptionField.Location = new Point(231, 195);
            taskDescriptionField.Name = "taskDescriptionField";
            taskDescriptionField.Size = new Size(300, 97);
            taskDescriptionField.TabIndex = 15;
            taskDescriptionField.Text = "";
            // 
            // taskTitleField
            // 
            taskTitleField.Location = new Point(231, 130);
            taskTitleField.Name = "taskTitleField";
            taskTitleField.Size = new Size(150, 31);
            taskTitleField.TabIndex = 14;
            // 
            // taskDueDatePicker
            // 
            taskDueDatePicker.Location = new Point(231, 339);
            taskDueDatePicker.Name = "taskDueDatePicker";
            taskDueDatePicker.Size = new Size(300, 31);
            taskDueDatePicker.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 339);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 12;
            label4.Text = "Due date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 218);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 11;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 136);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 10;
            label2.Text = "Title";
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(554, 379);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(130, 34);
            addTaskButton.TabIndex = 9;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 37);
            label1.Name = "label1";
            label1.Size = new Size(233, 33);
            label1.TabIndex = 8;
            label1.Text = "Task Manager";
            // 
            // MessageBox
            // 
            MessageBox.AutoSize = true;
            MessageBox.Location = new Point(574, 447);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(0, 25);
            MessageBox.TabIndex = 16;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 494);
            Controls.Add(MessageBox);
            Controls.Add(taskDescriptionField);
            Controls.Add(taskTitleField);
            Controls.Add(taskDueDatePicker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addTaskButton);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox taskDescriptionField;
        private TextBox taskTitleField;
        private DateTimePicker taskDueDatePicker;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addTaskButton;
        private Label label1;
        private Label MessageBox;
    }
}