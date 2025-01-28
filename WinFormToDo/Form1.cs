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

        private void submitForm(object sender, EventArgs e)
        {


            if (Validators.IsEmptyText(txtTaskDescription) || txtTaskDescription.Text == null)
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

            if (Validators.IsValidDate(txtDueDateBox))
            {
                MessageBox.Show("Date is Incorrectly Formatted, Please Resubmit.");
                return;
            }


            // Where we handle the add event

            ToDo myTodo = new ToDo(txtTaskDescription.Text, DateTime.Parse(txtDueDateBox.Text));


            MessageBox.Show(myTodo.ToString());


            lbTaskList.Items.Add(myTodo.ToString());


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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }
    }
}
