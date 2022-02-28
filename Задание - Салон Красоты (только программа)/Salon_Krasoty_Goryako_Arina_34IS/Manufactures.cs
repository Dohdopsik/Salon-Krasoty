using System;
using System.Windows.Forms;

namespace Salon_Krasoty_Goryako_Arina_34IS
{
    public partial class Manufactures : Form
    {
        public Manufactures()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salon_Krasoty_DBDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.salon_Krasoty_DBDataSet.Manufacturer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu f = new MainMenu();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
#pragma warning disable CS1503 // Аргумент 1: не удается преобразовать из "Salon_Krasoty_Goryako_Arina_34IS.Salon_Krasoty_DBDataSet" в "Salon_Krasoty_Goryako_Arina_34IS.Salon_Krasoty_DBDataSet2".
            this.tableAdapterManager1.UpdateAll(this.salon_Krasoty_DBDataSet);
       }
    }
}
