using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >='0')&& (e.KeyChar <= '9')|| e.KeyChar==8||e.KeyChar==13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')|| e.KeyChar==8||e.KeyChar==13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a, b;
           
            try
            {
                int sum = 0;
                a = Convert.ToInt32(txtA.Text);
                 b = Convert.ToInt32(txtB.Text);
                if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                }
                if (a > b)
                {
                    for (int i = b; i < a; i++)
                    {
                        sum += i;
                    }
                }

                lbSum.Text = "Tổng của các số từ " + a.ToString() + " đến " + b.ToString() + " là: " + sum.ToString();
            }
            catch(Exception)
            {
                
                MessageBox.Show("vui lòng nhập dữ liệu vào", "Thông báo");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lbSum.Text = "";
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
