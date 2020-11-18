namespace QuanLySV
{
    partial class DSNguoiQuen
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
            this.panelRoot = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSNguoiQuen = new System.Windows.Forms.DataGridView();
            this.llbTroVe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.llbThem = new System.Windows.Forms.LinkLabel();
            this.panelRoot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiQuen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoot
            // 
            this.panelRoot.BackColor = System.Drawing.Color.White;
            this.panelRoot.Controls.Add(this.groupBox1);
            this.panelRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRoot.Location = new System.Drawing.Point(0, 72);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(800, 802);
            this.panelRoot.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvDSNguoiQuen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 796);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh người quen";
            // 
            // dgvDSNguoiQuen
            // 
            this.dgvDSNguoiQuen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNguoiQuen.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDSNguoiQuen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNguoiQuen.Location = new System.Drawing.Point(6, 27);
            this.dgvDSNguoiQuen.Name = "dgvDSNguoiQuen";
            this.dgvDSNguoiQuen.RowHeadersWidth = 62;
            this.dgvDSNguoiQuen.RowTemplate.Height = 28;
            this.dgvDSNguoiQuen.Size = new System.Drawing.Size(782, 761);
            this.dgvDSNguoiQuen.TabIndex = 0;
            this.dgvDSNguoiQuen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiQuen_CellClick);
            // 
            // llbTroVe
            // 
            this.llbTroVe.AutoSize = true;
            this.llbTroVe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTroVe.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.llbTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbTroVe.LinkColor = System.Drawing.Color.Black;
            this.llbTroVe.Location = new System.Drawing.Point(12, 23);
            this.llbTroVe.Name = "llbTroVe";
            this.llbTroVe.Size = new System.Drawing.Size(93, 22);
            this.llbTroVe.TabIndex = 29;
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
            this.label1.Location = new System.Drawing.Point(311, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Người quen";
            // 
            // llbThem
            // 
            this.llbThem.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThem.AutoSize = true;
            this.llbThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThem.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThem.LinkColor = System.Drawing.Color.Green;
            this.llbThem.Location = new System.Drawing.Point(734, 23);
            this.llbThem.Name = "llbThem";
            this.llbThem.Size = new System.Drawing.Size(54, 22);
            this.llbThem.TabIndex = 31;
            this.llbThem.TabStop = true;
            this.llbThem.Text = "Thêm";
            this.llbThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThem.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThem_LinkClicked);
            // 
            // DSNguoiQuen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 875);
            this.Controls.Add(this.llbThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbTroVe);
            this.Controls.Add(this.panelRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSNguoiQuen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người quen";
            this.Load += new System.EventHandler(this.NguoiQuen_Load);
            this.panelRoot.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiQuen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.LinkLabel llbTroVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNguoiQuen;
        private System.Windows.Forms.LinkLabel llbThem;
    }
}