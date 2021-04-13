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
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap fr = new FrmDangNhap();
            fr.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ", "Thông báo", MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void danhMụcQuảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
