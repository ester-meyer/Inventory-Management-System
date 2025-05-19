using BlApi;
using DalApi;
using DO;

public enum Types { PRODUCT, SALE, CUSTOMER }

namespace UI
{
    public partial class ManagerController : Form
    {
        public ManagerController(Types type)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("third-background.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (type)
            {
                case Types.PRODUCT:
                    //dataGridView1.DataSource = Factory.Get.Product.ReadAll;
                    dataGridView1.DataSource = new List<Product>() { new Product("מכשיר ריצה", Categories.מכשירים, 3000, 10), new Product("משקולת 5 קילו", Categories.אביזרי_כושר, 50, 30), new Product("תיק ספורט", Categories.אקססוריז, 70, 30) };
                    break;
                    //case Types.SALE:
                    //    dataGridView1.DataSource = Factory.Get.Sale.ReadAll;
                    //    break;
                    //case Types.CUSTOMER:
                    //    dataGridView1.DataSource = Factory.Get.Customer.ReadAll;
                    //    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagerController_Load(object sender, EventArgs e)
        {

        }
    }
}
