using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_2
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtUser.Text == "Long" && txtPass.Text== "99999") {
                MessageBox.Show("chúc mừng bạn đã đăng nhâp thành công", "thông báo");
                this.Hide();
                fmMain fm = new fmMain();
                fm.Show();

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
