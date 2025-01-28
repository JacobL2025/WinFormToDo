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
            btnClear = new Button();
            btnAdd = new Button();
            txtDueDateBox = new TextBox();
            lblDueDate = new Label();
            lblTaskBoxLabel = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lbTaskList = new ListBox();
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
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(746, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(432, 147);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 45);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(584, 147);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add To-Do";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // txtDueDateBox
            // 
            txtDueDateBox.Location = new Point(129, 87);
            txtDueDateBox.Margin = new Padding(2);
            txtDueDateBox.Name = "txtDueDateBox";
            txtDueDateBox.PlaceholderText = "2025-01-20";
            txtDueDateBox.Size = new Size(602, 39);
            txtDueDateBox.TabIndex = 3;
            txtDueDateBox.KeyPress += Form1_KeyPress;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(5, 90);
            lblDueDate.Margin = new Padding(2, 0, 2, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(115, 32);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due Date";
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(28, 38);
            lblTaskBoxLabel.Margin = new Padding(2, 0, 2, 0);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(58, 32);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(129, 34);
            txtTaskDescription.Margin = new Padding(2);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(602, 39);
            txtTaskDescription.TabIndex = 0;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lbTaskList);
            gbTaskList.Location = new Point(15, 226);
            gbTaskList.Margin = new Padding(2);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Padding = new Padding(2);
            gbTaskList.Size = new Size(741, 724);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lbTaskList
            // 
            lbTaskList.FormattingEnabled = true;
            lbTaskList.Location = new Point(5, 37);
            lbTaskList.Name = "lbTaskList";
            lbTaskList.Size = new Size(737, 676);
            lbTaskList.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 961);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "To-Do App";
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
        private ListBox lbTaskList;
    }
}
