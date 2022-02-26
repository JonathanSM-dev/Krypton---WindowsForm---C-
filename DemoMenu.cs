using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp_PRODUCT_LIST
{
    public partial class DemoMenu : KryptonForm
    {
        public DemoMenu()
        {
            InitializeComponent();
        }

        private void productList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sql_inventoryDataSet.products'. Você pode movê-la ou removê-la conforme necessário.
            this.productsTableAdapter.Fill(this.sql_inventoryDataSet.products);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.sql_inventoryDataSet.products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Default", "https://www.linkedin.com/in/jonathan-silva-machado-43a725202/");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Default", "https://www.linkedin.com/in/jonathan-silva-machado-43a725202/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Default", "https://github.com/JonathanSM-dev");
        }
    }
}
