namespace QuanLySV
{
    partial class UserControlWallets
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpbImg = new QuanLySV.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.rpbImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.UserControlWallets_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.UserControlWallets_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.UserControlWallets_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(138, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(138, 32);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "My Wallet";
            this.labelName.Click += new System.EventHandler(this.UserControlWallets_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.UserControlWallets_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.UserControlWallets_MouseLeave);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(139, 48);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(127, 25);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "12,345,000 đ";
            this.labelMoney.Click += new System.EventHandler(this.UserControlWallets_Click);
            this.labelMoney.MouseEnter += new System.EventHandler(this.UserControlWallets_MouseEnter);
            this.labelMoney.MouseLeave += new System.EventHandler(this.UserControlWallets_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 3;
            // 
            // rpbImg
            // 
            this.rpbImg.BackColor = System.Drawing.Color.Transparent;
            this.rpbImg.Image = global::QuanLySV.Properties.Resources.different;
            this.rpbImg.Location = new System.Drawing.Point(30, 10);
            this.rpbImg.Name = "rpbImg";
            this.rpbImg.Size = new System.Drawing.Size(60, 60);
            this.rpbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rpbImg.TabIndex = 0;
            this.rpbImg.TabStop = false;
            this.rpbImg.Click += new System.EventHandler(this.UserControlWallets_Click);
            this.rpbImg.MouseEnter += new System.EventHandler(this.UserControlWallets_MouseEnter);
            this.rpbImg.MouseLeave += new System.EventHandler(this.UserControlWallets_MouseLeave);
            // 
            // UserControlWallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlWallets";
            this.Size = new System.Drawing.Size(570, 100);
            this.Click += new System.EventHandler(this.UserControlWallets_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlWallets_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlWallets_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundPictureBox rpbImg;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Panel panel2;
    }
}
