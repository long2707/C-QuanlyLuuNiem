using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DAO kn = new DAO();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGv.DataSource= kn.xuly("SELECT*FROM dbo.tblNhanvien");
            dataGv.AllowUserToOrderColumns = false;
            dataGv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGv.Columns[0].HeaderText = "Mã nhân viên";
            dataGv.Columns[0].Width = 200;
            dataGv.Columns[1].HeaderText = "Họ và tên";
            dataGv.Columns[1].Width = 200;
            dataGv.Columns[2].HeaderText = "Quê quán";
            dataGv.Columns[2].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtQQ.Text = "";
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Focus())
            {
                txtMa.Enabled = false;
            }

            

            
            kn.xuly("UPDATE tblNhanvien SET Hoten=N'"+txtName.Text.Trim()+"', Quequan='"+txtQQ.Text+"'");
            MessageBox.Show("dữ liệu cập nhật thành công", "Thông báo");
            dataGv.DataSource = kn.xuly("SELECT*FROM dbo.tblNhanvien");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            kn.xuly("DELETE tblNhanvien WHERE MaNV=N'" + txtMa.Text + "'");
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
            dataGv.DataSource = kn.xuly("SELECT*FROM dbo.tblNhanvien");
            txtMa.Text = "";
            txtName.Text = "";
            txtQQ.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string loi = "";
            if(txtMa.Text==""|| txtName.Text==""|| txtQQ.Text == "")
            {
                if (txtMa.Text == "")
                {
                    loi += "Vui lòng mã nhân viên vào!";
                }
                if (txtQQ.Text == "")
                {
                    loi += "Vui lòng nhập quê quán vào!";
                }
                if (txtName.Text == "")
                {
                    loi += "Vui lòng nhập tên vào!";
                }
                MessageBox.Show("" + loi, "Thông báo");
            }
            else
            {
                try
                {

                    kn.xuly("INSERT INTO tblNhanvien VALUES(N'" + txtMa.Text + "', N'" + txtName.Text + "', N'" + txtQQ.Text + "')");
                    MessageBox.Show("Dữ liệu được lưu thành công", "Thông báo");
                    dataGv.DataSource = kn.xuly("SELECT*FROM dbo.tblNhanvien");
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu bị trùng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
             
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtQQ.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát cương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMa.Text = dataGv.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGv.Rows[i].Cells[1].Value.ToString();
            txtQQ.Text = dataGv.Rows[i].Cells[2].Value.ToString();
        }
    }
}
