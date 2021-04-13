using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_c4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int n;
        string s;
        int[] a;
     void nhapMang()
        {
            n = Convert.ToInt32(txtN.Text);
            a = new int[n];
            s = "";
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(1, 100);
                s+=" "+a[i].ToString();

            }
            
           
        }
       
    

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                nhapMang();
                string d = "";
                for (int i = 0; i < a.Length; i++)
                {
                    d += " " + a[i].ToString();
                }
                lblDay.Text ="Dãy số: " +d;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào");
            }
            
          
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            lblSum.Text ="Tổng dãy số:"+ sum.ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Array.Sort(a);
            }
            string q = " ";
            for (int i = 0; i < a.Length; i++)
            {
                q += " " + a[i].ToString();
                
            }
            lblSort.Text ="Sắp xếp: "+q;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            lblDay.Text = "Dãy số: ";
            lblSum.Text = "Tổng dãy số: ";
            lblSort.Text = "sắp xếp: ";
            txtN.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'|| e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số", "Thông báo");
            }
        }
    }
        
}
