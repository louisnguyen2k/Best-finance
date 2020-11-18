namespace QuanLySV
{
    partial class MenuADMIN
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
            this.components = new System.ComponentModel.Container();
            this.panelUser = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llbLogOut = new System.Windows.Forms.LinkLabel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbToday = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.runText = new System.Windows.Forms.Timer(this.components);
            this.labelRun = new System.Windows.Forms.Label();
            this.panelRunText = new System.Windows.Forms.Panel();
            this.panelListButton = new System.Windows.Forms.Panel();
            this.btTaiKhoan = new ePOSOne.btnProduct.Button_WOC();
            this.btLapKeHoach = new ePOSOne.btnProduct.Button_WOC();
            this.btBaoCao = new ePOSOne.btnProduct.Button_WOC();
            this.btThemGiaoDich = new ePOSOne.btnProduct.Button_WOC();
            this.btSoGiaoDich = new ePOSOne.btnProduct.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUser.SuspendLayout();
            this.panelRunText.SuspendLayout();
            this.panelListButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Azure;
            this.panelUser.Controls.Add(this.linkLabel1);
            this.panelUser.Controls.Add(this.llbLogOut);
            this.panelUser.Controls.Add(this.lbDate);
            this.panelUser.Controls.Add(this.lbName);
            this.panelUser.Controls.Add(this.lbToday);
            this.panelUser.Controls.Add(this.lbUser);
            this.panelUser.Location = new System.Drawing.Point(1566, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(358, 145);
            this.panelUser.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(287, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llbLogOut
            // 
            this.llbLogOut.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llbLogOut.AutoSize = true;
            this.llbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogOut.LinkColor = System.Drawing.Color.Red;
            this.llbLogOut.Location = new System.Drawing.Point(287, 30);
            this.llbLogOut.Name = "llbLogOut";
            this.llbLogOut.Size = new System.Drawing.Size(65, 22);
            this.llbLogOut.TabIndex = 5;
            this.llbLogOut.TabStop = true;
            this.llbLogOut.Text = "Logout";
            this.llbLogOut.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogOut_LinkClicked);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDate.Location = new System.Drawing.Point(96, 98);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(102, 22);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "00-00-0000";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(96, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 25);
            this.lbName.TabIndex = 3;
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToday.Location = new System.Drawing.Point(8, 95);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(82, 27);
            this.lbToday.TabIndex = 2;
            this.lbToday.Text = "Today:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(8, 25);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(69, 27);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen3;
            this.panelMenu.Location = new System.Drawing.Point(0, 148);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1925, 874);
            this.panelMenu.TabIndex = 2;
            // 
            // runText
            // 
            this.runText.Enabled = true;
            this.runText.Interval = 15;
            this.runText.Tick += new System.EventHandler(this.runText_Tick);
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRun.ForeColor = System.Drawing.Color.Red;
            this.labelRun.Location = new System.Drawing.Point(12, 6);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(441, 41);
            this.labelRun.TabIndex = 4;
            this.labelRun.Text = "Phần mềm quản lý tài chính";
            // 
            // panelRunText
            // 
            this.panelRunText.BackColor = System.Drawing.Color.SkyBlue;
            this.panelRunText.Controls.Add(this.labelRun);
            this.panelRunText.Location = new System.Drawing.Point(0, 0);
            this.panelRunText.Name = "panelRunText";
            this.panelRunText.Size = new System.Drawing.Size(1567, 54);
            this.panelRunText.TabIndex = 5;
            // 
            // panelListButton
            // 
            this.panelListButton.Controls.Add(this.btTaiKhoan);
            this.panelListButton.Controls.Add(this.btLapKeHoach);
            this.panelListButton.Controls.Add(this.btBaoCao);
            this.panelListButton.Controls.Add(this.btThemGiaoDich);
            this.panelListButton.Controls.Add(this.btSoGiaoDich);
            this.panelListButton.Location = new System.Drawing.Point(0, 55);
            this.panelListButton.Name = "panelListButton";
            this.panelListButton.Size = new System.Drawing.Size(1567, 90);
            this.panelListButton.TabIndex = 6;
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.BorderColor = System.Drawing.Color.ForestGreen;
            this.btTaiKhoan.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btTaiKhoan.Location = new System.Drawing.Point(1026, 2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btTaiKhoan.OnHoverButtonColor = System.Drawing.Color.White;
            this.btTaiKhoan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btTaiKhoan.Size = new System.Drawing.Size(250, 84);
            this.btTaiKhoan.TabIndex = 7;
            this.btTaiKhoan.Text = "Tài khoản";
            this.btTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // btLapKeHoach
            // 
            this.btLapKeHoach.BackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.BorderColor = System.Drawing.Color.ForestGreen;
            this.btLapKeHoach.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btLapKeHoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLapKeHoach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLapKeHoach.FlatAppearance.BorderSize = 0;
            this.btLapKeHoach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLapKeHoach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapKeHoach.ForeColor = System.Drawing.Color.White;
            this.btLapKeHoach.Location = new System.Drawing.Point(770, 2);
            this.btLapKeHoach.Name = "btLapKeHoach";
            this.btLapKeHoach.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btLapKeHoach.OnHoverButtonColor = System.Drawing.Color.White;
            this.btLapKeHoach.OnHoverTextColor = System.Drawing.Color.Black;
            this.btLapKeHoach.Size = new System.Drawing.Size(250, 84);
            this.btLapKeHoach.TabIndex = 6;
            this.btLapKeHoach.Text = "Lập kế hoạch";
            this.btLapKeHoach.TextColor = System.Drawing.Color.Black;
            this.btLapKeHoach.UseVisualStyleBackColor = false;
            this.btLapKeHoach.Click += new System.EventHandler(this.btLapKeHoach_Click);
            // 
            // btBaoCao
            // 
            this.btBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.BorderColor = System.Drawing.Color.ForestGreen;
            this.btBaoCao.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBaoCao.FlatAppearance.BorderSize = 0;
            this.btBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCao.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCao.ForeColor = System.Drawing.Color.White;
            this.btBaoCao.Location = new System.Drawing.Point(258, 2);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btBaoCao.OnHoverButtonColor = System.Drawing.Color.White;
            this.btBaoCao.OnHoverTextColor = System.Drawing.Color.Black;
            this.btBaoCao.Size = new System.Drawing.Size(250, 84);
            this.btBaoCao.TabIndex = 4;
            this.btBaoCao.Text = "Báo cáo";
            this.btBaoCao.TextColor = System.Drawing.Color.Black;
            this.btBaoCao.UseVisualStyleBackColor = false;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // btThemGiaoDich
            // 
            this.btThemGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.BorderColor = System.Drawing.Color.ForestGreen;
            this.btThemGiaoDich.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btThemGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThemGiaoDich.FlatAppearance.BorderSize = 0;
            this.btThemGiaoDich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btThemGiaoDich.Location = new System.Drawing.Point(514, 2);
            this.btThemGiaoDich.Name = "btThemGiaoDich";
            this.btThemGiaoDich.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btThemGiaoDich.OnHoverButtonColor = System.Drawing.Color.White;
            this.btThemGiaoDich.OnHoverTextColor = System.Drawing.Color.Black;
            this.btThemGiaoDich.Size = new System.Drawing.Size(250, 84);
            this.btThemGiaoDich.TabIndex = 5;
            this.btThemGiaoDich.Text = "Thêm giao dịch";
            this.btThemGiaoDich.TextColor = System.Drawing.Color.Black;
            this.btThemGiaoDich.UseVisualStyleBackColor = false;
            this.btThemGiaoDich.Click += new System.EventHandler(this.btThemGiaoDich_Click);
            // 
            // btSoGiaoDich
            // 
            this.btSoGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.BorderColor = System.Drawing.Color.ForestGreen;
            this.btSoGiaoDich.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btSoGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSoGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSoGiaoDich.FlatAppearance.BorderSize = 0;
            this.btSoGiaoDich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSoGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btSoGiaoDich.Location = new System.Drawing.Point(2, 2);
            this.btSoGiaoDich.Name = "btSoGiaoDich";
            this.btSoGiaoDich.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btSoGiaoDich.OnHoverButtonColor = System.Drawing.Color.White;
            this.btSoGiaoDich.OnHoverTextColor = System.Drawing.Color.Black;
            this.btSoGiaoDich.Size = new System.Drawing.Size(250, 84);
            this.btSoGiaoDich.TabIndex = 3;
            this.btSoGiaoDich.Text = "Sổ giao dịch";
            this.btSoGiaoDich.TextColor = System.Drawing.Color.Black;
            this.btSoGiaoDich.UseVisualStyleBackColor = false;
            this.btSoGiaoDich.Click += new System.EventHandler(this.btSoGiaoDich_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1925, 3);
            this.panel1.TabIndex = 0;
            // 
            // MenuADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListButton);
            this.Controls.Add(this.panelRunText);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUser);
            this.Name = "MenuADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuADMIN_FormClosing);
            this.Load += new System.EventHandler(this.MenuADMIN_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelRunText.ResumeLayout(false);
            this.panelRunText.PerformLayout();
            this.panelListButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbToday;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.LinkLabel llbLogOut;
        private System.Windows.Forms.Panel panelMenu;
        private ePOSOne.btnProduct.Button_WOC btSoGiaoDich;
        private System.Windows.Forms.Timer runText;
        private System.Windows.Forms.Label labelRun;
        private System.Windows.Forms.Panel panelRunText;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelListButton;
        private ePOSOne.btnProduct.Button_WOC btTaiKhoan;
        private ePOSOne.btnProduct.Button_WOC btLapKeHoach;
        private ePOSOne.btnProduct.Button_WOC btBaoCao;
        private ePOSOne.btnProduct.Button_WOC btThemGiaoDich;
        private System.Windows.Forms.Panel panel1;
    }
}