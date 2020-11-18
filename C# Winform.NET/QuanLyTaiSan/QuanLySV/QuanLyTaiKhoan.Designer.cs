namespace QuanLySV
{
    partial class QuanLyTaiKhoan
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
            this.lbName = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panelEditName = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btEditName = new System.Windows.Forms.Button();
            this.rpbUser = new QuanLySV.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llbTroVe = new System.Windows.Forms.LinkLabel();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btDoiMK = new System.Windows.Forms.Button();
            this.btThayAnh = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panelEditName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(304, 256);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(210, 33);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Nguyễn Hiệp Lộc";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.panelEditName);
            this.panel.Controls.Add(this.btEditName);
            this.panel.Controls.Add(this.rpbUser);
            this.panel.Controls.Add(this.lbName);
            this.panel.Location = new System.Drawing.Point(0, 74);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 326);
            this.panel.TabIndex = 16;
            // 
            // panelEditName
            // 
            this.panelEditName.BackColor = System.Drawing.Color.White;
            this.panelEditName.Controls.Add(this.btCancel);
            this.panelEditName.Controls.Add(this.btSave);
            this.panelEditName.Controls.Add(this.tbNewName);
            this.panelEditName.Location = new System.Drawing.Point(246, 247);
            this.panelEditName.Name = "panelEditName";
            this.panelEditName.Size = new System.Drawing.Size(360, 55);
            this.panelEditName.TabIndex = 18;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.White;
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Image = global::QuanLySV.Properties.Resources.delete;
            this.btCancel.Location = new System.Drawing.Point(304, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(45, 45);
            this.btCancel.TabIndex = 19;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Image = global::QuanLySV.Properties.Resources.check;
            this.btSave.Location = new System.Drawing.Point(257, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(45, 45);
            this.btSave.TabIndex = 18;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewName.Location = new System.Drawing.Point(9, 10);
            this.tbNewName.Multiline = true;
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(242, 36);
            this.tbNewName.TabIndex = 17;
            // 
            // btEditName
            // 
            this.btEditName.BackColor = System.Drawing.Color.White;
            this.btEditName.ForeColor = System.Drawing.Color.White;
            this.btEditName.Image = global::QuanLySV.Properties.Resources.edit;
            this.btEditName.Location = new System.Drawing.Point(253, 251);
            this.btEditName.Name = "btEditName";
            this.btEditName.Size = new System.Drawing.Size(45, 45);
            this.btEditName.TabIndex = 19;
            this.btEditName.UseVisualStyleBackColor = false;
            this.btEditName.Click += new System.EventHandler(this.btEditName_Click);
            // 
            // rpbUser
            // 
            this.rpbUser.Image = global::QuanLySV.Properties.Resources.clone_img;
            this.rpbUser.Location = new System.Drawing.Point(310, 8);
            this.rpbUser.Name = "rpbUser";
            this.rpbUser.Size = new System.Drawing.Size(210, 210);
            this.rpbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbUser.TabIndex = 10;
            this.rpbUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // llbTroVe
            // 
            this.llbTroVe.AutoSize = true;
            this.llbTroVe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTroVe.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.llbTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbTroVe.LinkColor = System.Drawing.Color.Black;
            this.llbTroVe.Location = new System.Drawing.Point(12, 18);
            this.llbTroVe.Name = "llbTroVe";
            this.llbTroVe.Size = new System.Drawing.Size(93, 22);
            this.llbTroVe.TabIndex = 15;
            this.llbTroVe.TabStop = true;
            this.llbTroVe.Text = "      Trở về";
            this.llbTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbTroVe.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbTroVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTroVe_LinkClicked);
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.White;
            this.btDangXuat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btDangXuat.Image = global::QuanLySV.Properties.Resources.arrow_to_right;
            this.btDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDangXuat.Location = new System.Drawing.Point(0, 735);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(800, 75);
            this.btDangXuat.TabIndex = 14;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btDoiMK
            // 
            this.btDoiMK.BackColor = System.Drawing.Color.White;
            this.btDoiMK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiMK.Image = global::QuanLySV.Properties.Resources.arrow_to_right;
            this.btDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDoiMK.Location = new System.Drawing.Point(0, 625);
            this.btDoiMK.Name = "btDoiMK";
            this.btDoiMK.Size = new System.Drawing.Size(800, 75);
            this.btDoiMK.TabIndex = 13;
            this.btDoiMK.Text = "Đổi mật khẩu";
            this.btDoiMK.UseVisualStyleBackColor = false;
            this.btDoiMK.Click += new System.EventHandler(this.btDoiMK_Click);
            // 
            // btThayAnh
            // 
            this.btThayAnh.BackColor = System.Drawing.Color.White;
            this.btThayAnh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThayAnh.Image = global::QuanLySV.Properties.Resources.arrow_to_right;
            this.btThayAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThayAnh.Location = new System.Drawing.Point(0, 515);
            this.btThayAnh.Name = "btThayAnh";
            this.btThayAnh.Size = new System.Drawing.Size(800, 75);
            this.btThayAnh.TabIndex = 12;
            this.btThayAnh.Text = "Thay ảnh";
            this.btThayAnh.UseVisualStyleBackColor = false;
            this.btThayAnh.Click += new System.EventHandler(this.btThayAnh_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 875);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.llbTroVe);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.btDoiMK);
            this.Controls.Add(this.btThayAnh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelEditName.ResumeLayout(false);
            this.panelEditName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private RoundPictureBox rpbUser;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btDoiMK;
        private System.Windows.Forms.Button btThayAnh;
        private System.Windows.Forms.LinkLabel llbTroVe;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Panel panelEditName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEditName;
    }
}