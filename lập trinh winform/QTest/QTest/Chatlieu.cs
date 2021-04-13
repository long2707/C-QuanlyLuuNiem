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
    public partial class Chatlieu : Form
    {
        public Chatlieu()
        {
            InitializeComponent();
        }
        DAO kn = new DAO();
        private void Chatlieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kn.xyly("SELECT*FROM tblChatlieu");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[0].HeaderText = "Mã chất liệu";
            dataGridView1.Columns[1].HeaderText = "Tên chất liệu";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.xyly("INSERT INTO tblChatlieu VALUES('"+txtMacl.Text+"', N'"+txtTencl.Text+"')");
            dataGridView1.DataSource= kn.xyly("SELECT*FROM tblChatlieu");
        }
    }
}
