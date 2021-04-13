using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DAO data = new DAO();
        private void Form1_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = data.xuLy("SELECT*FROM tblchatlieu");
            dtGridView.AllowUserToOrderColumns = false;
            dtGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGridView.Columns[0].HeaderText = "Mã chất liệu";
            dtGridView.Columns[1].HeaderText = "Tên chất liệu";
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string loi = "";
            if (txtMacl.Text == "" || txtTencl.Text == "")
            {
                if (txtMacl.Text == "")
                {
                    loi += "Nhập tên mã chất liệu";
                }
                if (txtTencl.Text == "")
                {
                    loi += "Nhập tên chất liệu";
                }

                MessageBox.Show("" + loi, "Thông báo");
            }
            else
            {
                try
                {
                    data.xuLy("INSERT INTO tblchatlieu values('"+txtMacl.Text+"', '"+txtTencl.Text+"')");
                    MessageBox.Show("ĐÃ thêm thành công", "Thông báo");
                    dtGridView.DataSource = data.xuLy("SELECT*FROM tblchatlieu");
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("trùng dữ liệu", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                data.xuLy("DELETE tblchatlieu WHERE machatlieu='" + txtMacl.Text+"'");
                MessageBox.Show("XÓa dữ liệu thành công", "Thông báo");
                dtGridView.DataSource = data.xuLy("SELECT*FROM tblchatlieu"); 
            }
        }
    }
}
