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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("second-background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }
    }
}
