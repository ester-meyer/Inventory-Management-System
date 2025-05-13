namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
        }
    }
}
