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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccInp_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            string userID = "test";
            string passWD = "1234";
            if(AccInp.Text.Equals(userID) && PasInp.Text.Equals(passWD))
            {
                this.Close();
            }
            else MessageBox.Show("帳號或密碼錯誤");
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
