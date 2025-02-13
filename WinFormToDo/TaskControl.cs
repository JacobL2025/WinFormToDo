using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormToDo
{
    public partial class TaskControl : UserControl
    {
        private ToDo TaskData;

        public TaskControl(ToDo task)
        {
            InitializeComponent();
            TaskData = task;

            // add code to set my labels to the data

            lblDescription.Text = TaskData.TaskDescription;

            lblDueDate.Text = TaskData.DueDate.ToShortDateString();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void TaskControl_Load(object sender, EventArgs e)
        {

        }
    }
}
