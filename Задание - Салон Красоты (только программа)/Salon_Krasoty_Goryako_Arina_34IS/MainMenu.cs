using System;
using System.Windows.Forms;

namespace Salon_Krasoty_Goryako_Arina_34IS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Manufactures f = new Manufactures();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Products f = new Products();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            ProductSales f = new ProductSales();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
