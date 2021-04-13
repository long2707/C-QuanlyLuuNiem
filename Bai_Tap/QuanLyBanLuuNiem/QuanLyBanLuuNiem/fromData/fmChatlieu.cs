using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanLuuNiem.fromData
{
    public partial class fmChatlieu : Form
    {
        public fmChatlieu()
        {
            InitializeComponent();
        }


        DAO kn = new DAO();

        void Load_dataChatLieu()
        {
            txtMacl.Enabled = false;
            btnLuu.Enabled = false;
            dataGViewChatLieu.DataSource = kn.xuLy("SELECT*FROM tblChatlieu");
            dataGViewChatLieu.AllowUserToAddRows = false;
            dataGViewChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGViewChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dataGViewChatLieu.Columns[0].Width = 300;
            dataGViewChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            dataGViewChatLieu.Columns[1].Width = 300;

        }
        void ResertValue()
        {
            txtMacl.Text = "";
            txtTencl.Text = "";

        }
        private void fmChatlieu_Load(object sender, EventArgs e)
        {
            Load_dataChatLieu();
        }

        private void dataGViewChatLieu_Click(object sender, EventArgs e)
        {
            int i = dataGViewChatLieu.CurrentCell.RowIndex;
            txtMacl.Text = dataGViewChatLieu.Rows[i].Cells[0].Value.ToString();
            txtTencl.Text = dataGViewChatLieu.Rows[i].Cells[1].Value.ToString();

        }

        private void dataGViewChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            ResertValue();
            txtMacl.Enabled = true;
            txtMacl.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
             kn.xuLy("DELETE tblChatlieu where Machatlieu='" + txtMacl.Text + "'");
            MessageBox.Show( "Xóa dữ liệu thành công", "Thông báo");
            dataGViewChatLieu.DataSource= kn.xuLy("SELECT*FROM tblChatlieu");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMacl.Text == "")
            {
                MessageBox.Show( "Bạn chưa chọn dữ liệu cần sửa","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            kn.xuLy("UPDATE tblChatlieu SET Tenchatlieu ='" +txtTencl.Text.Trim() + "' where Machatlieu='"+txtMacl.Text+"'");
            MessageBox.Show("Dữ liệu cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel);
            dataGViewChatLieu.DataSource= kn.xuLy("SELECT*FROM tblChatlieu");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtMacl.Text == "" || txtTencl.Text == "")
            {
                string loi = "";
                if (txtMacl.Text == "")
                {
                    loi += "Vui lòng nhập dữ liệu vào";
                    txtMacl.Focus();
                }
                if (txtTencl.Text == "")
                {
                    loi += "Vui lòng không để trống";

                }
                MessageBox.Show(" " + loi, "Thông báo");
            }
            else
            {
                try
                {


                    kn.xuLy("INSERT INTO tblChatlieu VALUES('" + txtMacl.Text + "', N'" + txtTencl.Text + "')");
                    MessageBox.Show("đã thêm dữ liệu vào ", "Thông báo");

                    dataGViewChatLieu.DataSource = kn.xuLy("SELECT*FROM tblChatlieu");
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }
                catch
                {
                    MessageBox.Show(" Không được nhập mã chất liệu liệu vào ", "Thông báo");
                }
                
              
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
    }
