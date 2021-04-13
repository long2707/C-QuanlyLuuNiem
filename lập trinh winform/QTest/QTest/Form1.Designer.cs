
namespace QTest
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
            this.btnHang = new System.Windows.Forms.Button();
            this.btnChatlieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHang
            // 
            this.btnHang.Location = new System.Drawing.Point(239, 108);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(75, 66);
            this.btnHang.TabIndex = 0;
            this.btnHang.Text = "Hàng hóa";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnChatlieu
            // 
            this.btnChatlieu.Location = new System.Drawing.Point(434, 108);
            this.btnChatlieu.Name = "btnChatlieu";
            this.btnChatlieu.Size = new System.Drawing.Size(75, 66);
            this.btnChatlieu.TabIndex = 1;
            this.btnChatlieu.Text = "Chất liệu";
            this.btnChatlieu.UseVisualStyleBackColor = true;
            this.btnChatlieu.Click += new System.EventHandler(this.btnChatlieu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChatlieu);
            this.Controls.Add(this.btnHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button btnChatlieu;
    }
}

