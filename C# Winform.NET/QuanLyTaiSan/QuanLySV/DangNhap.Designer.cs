namespace QuanLySV
{
    partial class DangNhap
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
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.cbLuuTaiKhoan = new System.Windows.Forms.CheckBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.llbDangKiTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(34, 35);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(106, 25);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(34, 88);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(166, 35);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(214, 30);
            this.tbTaiKhoan.TabIndex = 1;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(166, 89);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(214, 30);
            this.tbMatKhau.TabIndex = 2;
            // 
            // cbLuuTaiKhoan
            // 
            this.cbLuuTaiKhoan.AutoSize = true;
            this.cbLuuTaiKhoan.Location = new System.Drawing.Point(250, 133);
            this.cbLuuTaiKhoan.Name = "cbLuuTaiKhoan";
            this.cbLuuTaiKhoan.Size = new System.Drawing.Size(143, 26);
            this.cbLuuTaiKhoan.TabIndex = 8;
            this.cbLuuTaiKhoan.Text = "Lưu tài khoản";
            this.cbLuuTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Red;
            this.btThoat.Image = global::QuanLySV.Properties.Resources.delete;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(277, 237);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(142, 55);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbHienMatKhau
            // 
            this.cbHienMatKhau.AutoSize = true;
            this.cbHienMatKhau.Location = new System.Drawing.Point(62, 133);
            this.cbHienMatKhau.Name = "cbHienMatKhau";
            this.cbHienMatKhau.Size = new System.Drawing.Size(173, 26);
            this.cbHienMatKhau.TabIndex = 7;
            this.cbHienMatKhau.Text = "Hiển thị mật khẩu";
            this.cbHienMatKhau.UseVisualStyleBackColor = true;
            this.cbHienMatKhau.CheckedChanged += new System.EventHandler(this.cbHienMatKhau_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tbTaiKhoan);
            this.groupBox.Controls.Add(this.cbHienMatKhau);
            this.groupBox.Controls.Add(this.lbTaiKhoan);
            this.groupBox.Controls.Add(this.lbMatKhau);
            this.groupBox.Controls.Add(this.tbMatKhau);
            this.groupBox.Controls.Add(this.cbLuuTaiKhoan);
            this.groupBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(18, 40);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(430, 175);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nhập tài khoản và mật khẩu";
            // 
            // llbDangKiTaiKhoan
            // 
            this.llbDangKiTaiKhoan.AutoSize = true;
            this.llbDangKiTaiKhoan.Location = new System.Drawing.Point(302, 299);
            this.llbDangKiTaiKhoan.Name = "llbDangKiTaiKhoan";
            this.llbDangKiTaiKhoan.Size = new System.Drawing.Size(146, 20);
            this.llbDangKiTaiKhoan.TabIndex = 10;
            this.llbDangKiTaiKhoan.TabStop = true;
            this.llbDangKiTaiKhoan.Text = "Chưa có tài khoản?";
            this.llbDangKiTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangKiTaiKhoan_click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btDangNhap.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.Teal;
            this.btDangNhap.Image = global::QuanLySV.Properties.Resources.log_out1;
            this.btDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangNhap.Location = new System.Drawing.Point(73, 237);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(154, 55);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(476, 331);
            this.Controls.Add(this.llbDangKiTaiKhoan);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThoat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.CheckBox cbLuuTaiKhoan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.CheckBox cbHienMatKhau;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.LinkLabel llbDangKiTaiKhoan;
    }
}