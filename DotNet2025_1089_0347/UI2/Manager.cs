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
    public partial class Manager : Form
    {
        
        public Manager()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("second-background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
       
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController controller = new ManagerController(Types.CUSTOMER);
            controller.FormClosed += (s, args) => this.Show();
            controller.Show();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController controller = new ManagerController(Types.SALE);
            controller.FormClosed += (s, args) => this.Show();
            controller.Show();
        }

        private void producstBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerController controller = new ManagerController(Types.PRODUCT);
            controller.FormClosed += (s, args) => this.Show();
            controller.Show();
        }
    }
}
