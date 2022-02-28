using System;
using System.Windows.Forms;

namespace Salon_Krasoty_Goryako_Arina_34IS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu f = new MainMenu();
            f.Show();
        }
    }
}
