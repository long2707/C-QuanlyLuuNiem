using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RadioButton rdb1 = new RadioButton();
        RadioButton rdb2= new RadioButton();
        void check()
        {
            
            
            rdb1.Text = "5%";
            rdb2.Text ="10%";
            
            panel1.Controls.Add(rdb1);
            panel2.Controls.Add(rdb2);

        }



        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số", "Thông báo");
            }
        }

        private void txtSolg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số", "Thông báo");
            }
        }
        private void btn_Sum_Click(object sender, EventArgs e)
        {

            if (cbxSale.Checked == true)
            {
                if (rdb1.Checked == true&& rdb2.Checked==false)
                {
                        float a = Convert.ToSingle(txtGia.Text);
                        float b = Convert.ToSingle(txtSolg.Text);
                        string sum = ((a + b) * 0.95).ToString();
                        txtSum.Text = sum;
                 
                }
                
                 if (rdb2.Checked== true && rdb2.Checked==false)
                  {
                        float a = Convert.ToSingle(txtGia.Text);
                        float b = Convert.ToSingle(txtSolg.Text);
                        string sum = ((a + b) * 0.90).ToString();
                        txtSum.Text = sum;
                  }
                
            }
            else
            {

                float a = Convert.ToSingle(txtGia.Text);
                float b = Convert.ToSingle(txtSolg.Text);
                string sum = (a + b).ToString();
                txtSum.Text = sum;
            }

          

           
           

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbxSale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSale.Checked == true)
            {
                check();
            }

        }

    }
}
