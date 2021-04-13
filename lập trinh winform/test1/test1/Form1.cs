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
namespace test1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        daoTesst kn = new daoTesst();
        bool cmb = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = kn.xuLy("Select*FROM tblchatlieu");
            
            comboBox1.DataSource = kn.xuLy("Select*FROM tblchatlieu");
          
            comboBox1.DisplayMember = "tenchatlieu";

            comboBox1.ValueMember = "machatlieu";
            comboBox1.SelectedIndex = -1;
            cmb = true;

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb)
            {


                string a = comboBox1.Text;

                dataGridView1.DataSource = kn.xuLy("SELECT*FROM tblchatlieu WHERE tenchatlieu=N'" + a + "'");

            }
        }
    }
}
