namespace QuanLySV
{
    partial class ThemNguoiQuen
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
            this.llbTroVe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llbThem = new System.Windows.Forms.LinkLabel();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbTroVe
            // 
            this.llbTroVe.AutoSize = true;
            this.llbTroVe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTroVe.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.llbTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbTroVe.LinkColor = System.Drawing.Color.Black;
            this.llbTroVe.Location = new System.Drawing.Point(12, 14);
            this.llbTroVe.Name = "llbTroVe";
            this.llbTroVe.Size = new System.Drawing.Size(93, 22);
            this.llbTroVe.TabIndex = 30;
            this.llbTroVe.TabStop = true;
            this.llbTroVe.Text = "      Trở về";
            this.llbTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbTroVe.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbTroVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTroVe_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thên người quen";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Location = new System.Drawing.Point(0, 74);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 423);
            this.panel.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 355);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(242, 188);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDiaChi.Size = new System.Drawing.Size(455, 132);
            this.tbDiaChi.TabIndex = 12;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(242, 118);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(455, 40);
            this.tbSDT.TabIndex = 11;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSDT_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(242, 48);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(455, 40);
            this.tbName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ:";
            // 
            // llbThem
            // 
            this.llbThem.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThem.AutoSize = true;
            this.llbThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThem.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThem.LinkColor = System.Drawing.Color.Green;
            this.llbThem.Location = new System.Drawing.Point(734, 14);
            this.llbThem.Name = "llbThem";
            this.llbThem.Size = new System.Drawing.Size(54, 22);
            this.llbThem.TabIndex = 33;
            this.llbThem.TabStop = true;
            this.llbThem.Text = "Thêm";
            this.llbThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThem.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThem_LinkClicked);
            // 
            // ThemNguoiQuen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.llbThem);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbTroVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemNguoiQuen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiQuen";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbTroVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbThem;
    }
}