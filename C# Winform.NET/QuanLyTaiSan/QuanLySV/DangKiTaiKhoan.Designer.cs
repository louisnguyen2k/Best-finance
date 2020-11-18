namespace QuanLySV
{
    partial class DangKiTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMK1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMK2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btDangKi = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÍ TÀI KHOẢN";
            // 
            // tbMK1
            // 
            this.tbMK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK1.Location = new System.Drawing.Point(203, 139);
            this.tbMK1.Name = "tbMK1";
            this.tbMK1.PasswordChar = '*';
            this.tbMK1.Size = new System.Drawing.Size(283, 35);
            this.tbMK1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // tbMK2
            // 
            this.tbMK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK2.Location = new System.Drawing.Point(203, 191);
            this.tbMK2.Name = "tbMK2";
            this.tbMK2.PasswordChar = '*';
            this.tbMK2.Size = new System.Drawing.Size(283, 35);
            this.tbMK2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // btDangKi
            // 
            this.btDangKi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btDangKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKi.ForeColor = System.Drawing.Color.Teal;
            this.btDangKi.Image = global::QuanLySV.Properties.Resources.sign_up;
            this.btDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangKi.Location = new System.Drawing.Point(99, 369);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(160, 70);
            this.btDangKi.TabIndex = 9;
            this.btDangKi.Text = "     Đăng kí";
            this.btDangKi.UseVisualStyleBackColor = false;
            this.btDangKi.Click += new System.EventHandler(this.btDangKi_Click_1);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Red;
            this.btHuy.Image = global::QuanLySV.Properties.Resources.delete;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(321, 369);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(160, 70);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.tbTenNguoiDung);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTenTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMK2);
            this.groupBox1.Controls.Add(this.tbMK1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 265);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tbTenNguoiDung
            // 
            this.tbTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNguoiDung.Location = new System.Drawing.Point(203, 85);
            this.tbTenNguoiDung.Name = "tbTenNguoiDung";
            this.tbTenNguoiDung.Size = new System.Drawing.Size(283, 35);
            this.tbTenNguoiDung.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên người dùng:";
            // 
            // tbTenTK
            // 
            this.tbTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTK.Location = new System.Drawing.Point(203, 29);
            this.tbTenTK.Name = "tbTenTK";
            this.tbTenTK.Size = new System.Drawing.Size(283, 35);
            this.tbTenTK.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản:";
            // 
            // DangKiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDangKi);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label1);
            this.Name = "DangKiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMK2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTenNguoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenTK;
        private System.Windows.Forms.Label label2;
    }
}