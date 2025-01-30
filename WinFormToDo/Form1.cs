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
                //.Where(t => t.IsDone == false)
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

        private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show($"Selected Index is: {lbTaskList.SelectedIndex}");
           int selectedIndex = lbTaskList.SelectedIndex;
            string selectedItem = (string)lbTaskList.SelectedItem;

           
            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedItem == null)
            {
                MessageBox.Show("No Item Selected at The Index");
                return;
            }

            //String Format: # - 01-01-2025 - description - status: complete

            int id = Int32.Parse(selectedItem.Split(" - ")[0]);

            // Find the item in the list with the matching id, toggle it complete status

            var Todo = TaskList.Find(t => t.Id == id);

            if (Todo != null)
            {
                Todo.IsDone = !Todo.IsDone;

                UpdateListBox();
            }

        }
    }
}
