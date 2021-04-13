using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dao kn = new Dao();

        void ResertValue()
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            cbxManxb.Text = "";
            txtSoluong.Text = "";
            txtGia.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResertValue();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtMasach.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có muốn xóa không", "Thông báo") == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kn.xuly("INSERT INTO tblHang VALUES('" + txtMasach.Text + "', '" + txtTensach.Text + "', '" + cbxManxb.Text + "', '" + txtSoluong.Text + "', '" + txtGia.Text + "', '" + txtAnh.Text + "')");

            dataGrid.DataSource = kn.xuly("SELECT*FROM tblsach");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = kn.xuly("SELECT*FROM tblsach");
            dataGrid.AllowUserToAddRows = false;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            cbxManxb.DataSource = kn.xuly("SELECT*FROM tblNxb");
            cbxManxb.DisplayMember = "TenNXB";
            cbxManxb.ValueMember = "Manxb";
            cbxManxb.SelectedIndex= -1;
            dataGrid.Columns[0].HeaderText = "Mã sách";
            dataGrid.Columns[0].Width = 200;
            dataGrid.Columns[1].HeaderText = "Tên sách";
            dataGrid.Columns[1].Width = 200;
            dataGrid.Columns[2].HeaderText = "Mã nhà xuất bản";
            dataGrid.Columns[2].Width = 200;
            dataGrid.Columns[3].HeaderText = "Số lượng";
            dataGrid.Columns[3].Width = 100;
            dataGrid.Columns[4].HeaderText = "Giá sách";
            dataGrid.Columns[4].Width = 100;
            dataGrid.Columns[5].HeaderText = "Ảnh";
            dataGrid.Columns[5].Width = 350;
            btnLuu.Enabled = false;
            txtMasach.Enabled = false;
            
        }

        private void dataGrid_Click(object sender, EventArgs e)
        {
            int i = dataGrid.CurrentCell.RowIndex;
           txtMasach.Text =dataGrid.Rows[i].Cells[0].Value.ToString();
            txtTensach.Text=dataGrid.Rows[i].Cells[1].Value.ToString();
            cbxManxb.Text=dataGrid.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text=dataGrid.Rows[i].Cells[3].Value.ToString();
            txtGia.Text=dataGrid.Rows[i].Cells[4].Value.ToString();
            txtAnh.Text=dataGrid.Rows[i].Cells[5].Value.ToString();
          
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = ("Pictures files(*.png, *.jpg)|*png; *jpg");
            openFile.FilterIndex = 1;
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFile.FileName);
            }
        }
    }
}
