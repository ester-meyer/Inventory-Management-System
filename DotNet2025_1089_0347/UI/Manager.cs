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
            this.BackgroundImage = Image.FromFile("background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
