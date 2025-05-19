using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }



        private void managerBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.FormClosed += (s, args) => this.Show();
            manager.Show();
        }

        private void cashierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier cashier = new Cashier();
            cashier.FormClosed += (s, args) => this.Show();
            cashier.Show();
        }
    }
}
