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
    public enum Type { Customer, Product, Sale}
    public partial class Operations : Form
    {
        public Operations(Type t)
        {
            InitializeComponent();
            Type.Text = t.ToString();
            switch (t)
            {
                case UI.Type.Customer:
                    dataGridView1.DataSource = t;
                    break;
                case UI.Type.Product:
                    dataGridView1.DataSource = t; 
                    break;
                case UI.Type.Sale:
                    dataGridView1.DataSource = t; 
                    break;
            }
        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
