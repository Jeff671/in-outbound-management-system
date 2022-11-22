using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void inputdata_Click(object sender, EventArgs e)
        {
            string input_price = pricetext.Text;
            string input_num = mounttext.Text;
            string in_outlog = "";
            string shipmentlog = shipmentbar.SelectedItem.ToString();
            double price = Convert.ToDouble(input_price);
            double num = Convert.ToDouble(input_num);
            if (inshipment.Checked == true)
            {
                in_outlog = "進貨";
            }
            else in_outlog = "出貨";
            showlog.Text = string.Format("總價:{0} {1} {2}", price * num, in_outlog, shipmentlog);

            DataGridViewRowCollection rows = dataGridView1.Rows;
            DateTime date = DateTime.Now;
            rows.Add(new object[] { "", date.ToString("yyyy/MM/dd HH:mm:ss"), in_outlog, shipmentlog,price,num,price * num});
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is about");
        }

        private void shipment_Click(object sender, EventArgs e)
        {

        }

        private void num_Click(object sender, EventArgs e)
        {

        }

        private void shipmentbar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
