using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            Hang ha = new Hang();
            ha.ShowDialog();
        }

        private void btnChatlieu_Click(object sender, EventArgs e)
        {
            Chatlieu cl = new Chatlieu();
            cl.ShowDialog();
        }
    }
}
