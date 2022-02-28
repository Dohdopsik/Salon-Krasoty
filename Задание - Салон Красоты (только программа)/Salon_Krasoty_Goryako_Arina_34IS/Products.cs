using System;
using System.Windows.Forms;

namespace Salon_Krasoty_Goryako_Arina_34IS
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salon_Krasoty_DBDataSet1.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.salon_Krasoty_DBDataSet1.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu f = new MainMenu();
            f.Show();
        }
    }
}
