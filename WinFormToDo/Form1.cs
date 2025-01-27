using System.Security.Cryptography.X509Certificates;

namespace WinFormToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var date = DateTime.Parse(txtDueDateBox.Text);

            // Where we handle the add event

            ToDo myTodo = new ToDo(txtTaskDescription.Text, DateTime.Parse(txtDueDateBox.Text));


            MessageBox.Show(myTodo.ToString());


            lvTasks.Items.Add(myTodo.ToString());


            ClearForm();

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
    }
}
