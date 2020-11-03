namespace QuanLiQuanTraSua
{
    partial class fLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDangNhap = new System.Windows.Forms.Button();
            this.ButtonThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextBoxDangNhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(61, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 45);
            this.panel2.TabIndex = 1;
            // 
            // TextBoxDangNhap
            // 
            this.TextBoxDangNhap.Location = new System.Drawing.Point(169, 10);
            this.TextBoxDangNhap.Name = "TextBoxDangNhap";
            this.TextBoxDangNhap.Size = new System.Drawing.Size(234, 22);
            this.TextBoxDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextBoxMatKhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(61, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 45);
            this.panel3.TabIndex = 2;
            // 
            // TextBoxMatKhau
            // 
            this.TextBoxMatKhau.Location = new System.Drawing.Point(169, 10);
            this.TextBoxMatKhau.Name = "TextBoxMatKhau";
            this.TextBoxMatKhau.Size = new System.Drawing.Size(234, 22);
            this.TextBoxMatKhau.TabIndex = 1;
            this.TextBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu ";
            // 
            // ButtonDangNhap
            // 
            this.ButtonDangNhap.Location = new System.Drawing.Point(165, 158);
            this.ButtonDangNhap.Name = "ButtonDangNhap";
            this.ButtonDangNhap.Size = new System.Drawing.Size(96, 32);
            this.ButtonDangNhap.TabIndex = 3;
            this.ButtonDangNhap.Text = "Đăng Nhập";
            this.ButtonDangNhap.UseVisualStyleBackColor = true;
            this.ButtonDangNhap.Click += new System.EventHandler(this.ButtonDangNhap_Click);
            // 
            // ButtonThoat
            // 
            this.ButtonThoat.Location = new System.Drawing.Point(305, 158);
            this.ButtonThoat.Name = "ButtonThoat";
            this.ButtonThoat.Size = new System.Drawing.Size(96, 32);
            this.ButtonThoat.TabIndex = 4;
            this.ButtonThoat.Text = "Thoát";
            this.ButtonThoat.UseVisualStyleBackColor = true;
            this.ButtonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.ButtonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 202);
            this.Controls.Add(this.ButtonThoat);
            this.Controls.Add(this.ButtonDangNhap);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDangNhap;
        private System.Windows.Forms.Button ButtonThoat;
    }
}