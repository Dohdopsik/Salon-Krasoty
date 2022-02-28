using System;
using System.Windows.Forms;

namespace Salon_Krasoty_Goryako_Arina_34IS
{
    public partial class ProductSales : Form
    {
        public ProductSales()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salon_Krasoty_DBDataSet2.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.salon_Krasoty_DBDataSet2.ProductSale);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu f = new MainMenu();
            f.Show();
        }
    }
}
