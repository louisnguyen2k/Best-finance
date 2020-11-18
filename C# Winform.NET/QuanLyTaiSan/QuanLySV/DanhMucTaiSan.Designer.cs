namespace QuanLySV
{
    partial class DanhMucTaiSan
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.llbThemVi = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.llbTroVe = new System.Windows.Forms.LinkLabel();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.Controls.Add(this.flowLayoutPanel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox.Location = new System.Drawing.Point(0, 60);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(800, 810);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "     Danh sách tài sản";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 29);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 781);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // llbThemVi
            // 
            this.llbThemVi.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThemVi.AutoSize = true;
            this.llbThemVi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThemVi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThemVi.LinkColor = System.Drawing.Color.Green;
            this.llbThemVi.Location = new System.Drawing.Point(677, 16);
            this.llbThemVi.Name = "llbThemVi";
            this.llbThemVi.Size = new System.Drawing.Size(110, 22);
            this.llbThemVi.TabIndex = 23;
            this.llbThemVi.TabStop = true;
            this.llbThemVi.Text = "Thêm tài sản";
            this.llbThemVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThemVi.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThemVi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemVi_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tài sản";
            // 
            // llbTroVe
            // 
            this.llbTroVe.AutoSize = true;
            this.llbTroVe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTroVe.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.llbTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbTroVe.LinkColor = System.Drawing.Color.Black;
            this.llbTroVe.Location = new System.Drawing.Point(12, 16);
            this.llbTroVe.Name = "llbTroVe";
            this.llbTroVe.Size = new System.Drawing.Size(93, 22);
            this.llbTroVe.TabIndex = 21;
            this.llbTroVe.TabStop = true;
            this.llbTroVe.Text = "      Trở về";
            this.llbTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbTroVe.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbTroVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTroVe_LinkClicked);
            // 
            // DanhMucTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 875);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.llbThemVi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbTroVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucTaiSan";
            this.Text = "DanhMucTaiSan";
            this.Load += new System.EventHandler(this.DanhMucTaiSan_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.LinkLabel llbThemVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbTroVe;
    }
}