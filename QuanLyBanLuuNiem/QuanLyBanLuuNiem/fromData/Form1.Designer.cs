
namespace QuanLyBanLuuNiem.fromData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnTaptin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDmChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDmNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDmKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDmHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTaptin,
            this.mnDanhmuc,
            this.mnHoadon,
            this.mnTimkiem,
            this.mnBaocao,
            this.mnTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnTaptin
            // 
            this.mnTaptin.Name = "mnTaptin";
            this.mnTaptin.Size = new System.Drawing.Size(69, 26);
            this.mnTaptin.Text = "Tập tin";
            // 
            // mnDanhmuc
            // 
            this.mnDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDmChatlieu,
            this.mnDmNhanvien,
            this.mnDmKhachhang,
            this.mnDmHanghoa});
            this.mnDanhmuc.Name = "mnDanhmuc";
            this.mnDanhmuc.Size = new System.Drawing.Size(94, 24);
            this.mnDanhmuc.Text = "Danh mục ";
            // 
            // mnDmChatlieu
            // 
            this.mnDmChatlieu.Name = "mnDmChatlieu";
            this.mnDmChatlieu.Size = new System.Drawing.Size(224, 26);
            this.mnDmChatlieu.Text = "Chất liệu";
            this.mnDmChatlieu.Click += new System.EventHandler(this.mnDmChatlieu_Click);
            // 
            // mnDmNhanvien
            // 
            this.mnDmNhanvien.Name = "mnDmNhanvien";
            this.mnDmNhanvien.Size = new System.Drawing.Size(169, 26);
            this.mnDmNhanvien.Text = "Nhân viên";
            // 
            // mnDmKhachhang
            // 
            this.mnDmKhachhang.Name = "mnDmKhachhang";
            this.mnDmKhachhang.Size = new System.Drawing.Size(169, 26);
            this.mnDmKhachhang.Text = "Khách hàng";
            // 
            // mnDmHanghoa
            // 
            this.mnDmHanghoa.Name = "mnDmHanghoa";
            this.mnDmHanghoa.Size = new System.Drawing.Size(169, 26);
            this.mnDmHanghoa.Text = "Hàng hóa";
            // 
            // mnHoadon
            // 
            this.mnHoadon.Name = "mnHoadon";
            this.mnHoadon.Size = new System.Drawing.Size(85, 26);
            this.mnHoadon.Text = "Hóa đơn ";
            // 
            // mnTimkiem
            // 
            this.mnTimkiem.Name = "mnTimkiem";
            this.mnTimkiem.Size = new System.Drawing.Size(84, 26);
            this.mnTimkiem.Text = "Tìm kiếm";
            // 
            // mnBaocao
            // 
            this.mnBaocao.Name = "mnBaocao";
            this.mnBaocao.Size = new System.Drawing.Size(77, 26);
            this.mnBaocao.Text = "Báo cáo";
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(78, 26);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(221, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chương trình quản lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(277, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bán hàng lưu niệm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(830, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý bán hàng lưu niệm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnTaptin;
        private System.Windows.Forms.ToolStripMenuItem mnDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnDmChatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnDmNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnDmKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnDmHanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

