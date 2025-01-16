namespace WinFormToDo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtTaskDescription = new TextBox();
            lblTaskBoxLabel = new Label();
            lblDueDate = new Label();
            txtDueDateBox = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            gbTaskList = new GroupBox();
            lvTasks = new ListView();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtDueDateBox);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(lblTaskBoxLabel);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(149, 39);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(694, 43);
            txtTaskDescription.TabIndex = 0;
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(32, 45);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(66, 37);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 104);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(128, 37);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due Date";
            // 
            // txtDueDateBox
            // 
            txtDueDateBox.Location = new Point(149, 101);
            txtDueDateBox.Name = "txtDueDateBox";
            txtDueDateBox.PlaceholderText = "2025-01-20";
            txtDueDateBox.Size = new Size(694, 43);
            txtDueDateBox.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(674, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 52);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add To-Do";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(499, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(169, 52);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lvTasks);
            gbTaskList.Location = new Point(18, 261);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(855, 838);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lvTasks
            // 
            lvTasks.Location = new Point(6, 42);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(849, 796);
            lvTasks.TabIndex = 0;
            lvTasks.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 1111);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTaskBoxLabel;
        private TextBox txtTaskDescription;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtDueDateBox;
        private Label lblDueDate;
        private GroupBox gbTaskList;
        private ListView lvTasks;
    }
}
