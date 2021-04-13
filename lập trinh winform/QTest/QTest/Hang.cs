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
    public partial class Hang : Form
    {
        public Hang()
        {
            InitializeComponent();
        }
        DAO kn = new DAO();
        private void Hang_Load(object sender, EventArgs e)
        {
            cbxMacl.DataSource = kn.xyly("SELECT * FROM tblChatlieu");
            cbxMacl.DisplayMember = "Tenchatlieu";
            cbxMacl.ValueMember = "Machatlieu";
            cbxMacl.SelectedIndex = -1;
            dataGridView2.DataSource = kn.xyly("SELECT * FROM tblHang");
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = ("Pictures files(*.png, *.jpg)|*.png; *.jpg|All files(*.*)|*.*");
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                txtAnh.Text = openFile.FileName;
            }
        }

        private void btnLuuH_Click(object sender, EventArgs e)
        {
            kn.xyly("INSERT INTO tblHang VALUES('" + txtMahang.Text + "', '" + txtTenhang.Text + "', '" + cbxMacl.SelectedValue.ToString() + "', '" + txtSoluong.Text + "', '" + txtAnh.Text + "')");
            dataGridView2.DataSource = kn.xyly("SELECT*FROM tblHang");
        }
    }
}
