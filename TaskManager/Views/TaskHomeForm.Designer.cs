namespace TaskManager.Views
{
    partial class TaskHomeForm
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
            label1 = new Label();
            ToDoGroupBox = new GroupBox();
            groupBox2 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Whasssaup";
            // 
            // ToDoGroupBox
            // 
            ToDoGroupBox.Location = new Point(170, 108);
            ToDoGroupBox.Name = "ToDoGroupBox";
            ToDoGroupBox.Size = new Size(300, 592);
            ToDoGroupBox.TabIndex = 1;
            ToDoGroupBox.TabStop = false;
            ToDoGroupBox.Text = "To do";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(668, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 592);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Done";
            // 
            // TaskHomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 758);
            Controls.Add(groupBox2);
            Controls.Add(ToDoGroupBox);
            Controls.Add(label1);
            Name = "TaskHomeForm";
            Text = "TaskHomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox ToDoGroupBox;
        private GroupBox groupBox2;
    }
}