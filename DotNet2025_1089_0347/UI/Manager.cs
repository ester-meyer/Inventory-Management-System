using BlApi;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations operationsForm = new Operations(Type.Sale);
            operationsForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Operations operationsForm = new Operations(Type.Product);
            operationsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operations operationsForm = new Operations(Type.Customer);
            operationsForm.Show();
        }
    }
}
