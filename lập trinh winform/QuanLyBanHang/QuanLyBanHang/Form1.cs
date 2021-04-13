using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DAO kn = new DAO();
        void ResertValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMoTa.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            dataGridV.DataSource = kn.xuly("SELECT*FROM tblHang");
            dataGridV.AllowUserToAddRows = false;
            dataGridV.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridV.Columns[0].HeaderText = "Mã chất liệu";
            dataGridV.Columns[0].Width = 150;
            dataGridV.Columns[1].HeaderText = "Tên chất liệu";
            dataGridV.Columns[1].Width = 200;
            dataGridV.Columns[2].HeaderText = "Mô tả chất liệu";
            dataGridV.Columns[2].Width = 350;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResertValue();
            txtMaHang.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
           
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string loi = "";
            if(txtMaHang.Text==""|| txtTenHang.Text == "" || txtMoTa.Text == "")
            {
                if (txtMaHang.Text == "")
                {
                    loi += "Vui lòng nhập mã hàng";
                    txtMaHang.Focus();
                }
                if (txtTenHang.Text == "")
                {
                    loi += "vui lòng nhập tên hàng ";
                    txtTenHang.Focus();
                }
                if (txtMoTa.Text == "")
                {
                    loi += "vui lòng nhập mô tả cho hàng ";
                    txtMoTa.Focus();
                }
                MessageBox.Show("" + loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    kn.xuly("INSERT INTO tblHang VALUES('" + txtMaHang.Text.Trim() + "', N'" + txtTenHang.Text.Trim() + "', N'" + txtMoTa.Text.Trim() + "')");
                    MessageBox.Show("Đã thêm sản phẩm thành công", "Thông báo");
                    dataGridV.DataSource = kn.xuly("SELECT*FROM tblHang");
                    ResertValue();
                    txtMaHang.Enabled = false;
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sản phẩm trùng với mã sản phẩm cũ", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "" || txtMoTa.Text == "")
            {
                if (txtTenHang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên hàng ", "Thông báo");
                    txtTenHang.Focus();

                }
                if (txtMoTa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mô tả cho hàng ", "Thông báo");
                    txtMoTa.Focus();

                }
            }
            else
            {
                kn.xuly("UPDATE tblHang SET TenHang =N'" + txtTenHang.Text.Trim() + "', MoTa= N'"+txtMoTa.Text.Trim()+"' where MaHang='" + txtMaHang.Text.Trim() + "'");
                MessageBox.Show("Đã sửa  sản phẩm thành công", "Thông báo");
                ResertValue();
                dataGridV.DataSource = kn.xuly("SELECT*FROM tblHang");

            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text==""|| txtTenHang.Text==""|| txtMoTa.Text==""){
                MessageBox.Show("bạn chưa chọn sản phẩm để xóa", "Thông báo");

            }
            kn.xuly("DELETE tblHang WHERE MaHang='" + txtMaHang.Text + "'");
            MessageBox.Show("Đã xóa  sản phẩm thành công", "Thông báo");
            dataGridV.DataSource = kn.xuly("SELECT*FROM tblHang");
            ResertValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridV_Click(object sender, EventArgs e)
        {
            int i = dataGridV.CurrentRow.Index;
            txtMaHang.Text = dataGridV.Rows[i].Cells[0].Value.ToString();
            txtTenHang.Text = dataGridV.Rows[i].Cells[1].Value.ToString();
            txtMoTa.Text = dataGridV.Rows[i].Cells[2].Value.ToString();
        }
    }
}
