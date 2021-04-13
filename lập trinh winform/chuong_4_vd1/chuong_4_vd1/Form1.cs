using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong_4_vd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);

            lblSum.Text = "Tổng của hai số:" + (a + b).ToString();
        }

        //private void txtA_KeyDown(object sender, KeyEventArgs e)
        //{
        //    int a;
        //    a = Convert.ToInt32(e.KeyCode);
        //    //txtA.Text = a.ToString();
        //    MessageBox.Show(a.ToString());
        //}

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9'))
)
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
                MessageBox.Show("chỉ nhập số", "thông báo");
                    }
        }
    }
}
