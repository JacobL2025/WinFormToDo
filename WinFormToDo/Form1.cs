using System.Security.Cryptography.X509Certificates;

namespace WinFormToDo
{
    public partial class Form1 : Form
    {
        private List<ToDo> TaskList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<ToDo>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void submitForm(object sender, EventArgs e)
        {


            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Invalid Data. Please Try Again.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description Needs To Be Created");
                return;
            }

            if (Validators.IsEmptyText(txtDueDateBox))
            {
                MessageBox.Show("Missing A Due Date");
                return;
            }

            if (!Validators.IsValidDate(txtDueDateBox))
            {
                MessageBox.Show("Date is Incorrectly Formatted, Please Resubmit.");
                return;
            }


            // Where we handle the add event

            ToDo myTodo = new ToDo(txtTaskDescription.Text, DateTime.Parse(txtDueDateBox.Text));

            TaskList.Add(myTodo);

            UpdateListBox();

            MessageBox.Show(myTodo.ToString());


            // lbTaskList.Items.Add(myTodo.ToString());


            ClearForm();

        }

        public void UpdateListBox()
        {
            //Clear the contents of the list box
            lbTaskList.Items.Clear();

            // Transform the list
            var list = TaskList
                .Where(t => t.IsDone == false)
                .OrderBy(testc => testc.DueDate)
                .ToList();

            
            // read in the new contents
            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }

            // clean up if required
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }

        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDateBox.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }
    }
}
