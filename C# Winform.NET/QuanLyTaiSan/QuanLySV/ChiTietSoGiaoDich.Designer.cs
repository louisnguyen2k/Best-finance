namespace QuanLySV
{
    partial class ChiTietSoGiaoDich
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.gbGiaoDichThoiGian = new System.Windows.Forms.GroupBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.rbtMocDinhKi = new System.Windows.Forms.RadioButton();
            this.gbGiaoDichDinhKi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDinhKi = new System.Windows.Forms.ComboBox();
            this.rbtMocThoiGian = new System.Windows.Forms.RadioButton();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.gbGiaoDichThoiGian.SuspendLayout();
            this.gbGiaoDichDinhKi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.gbGiaoDichThoiGian);
            this.panelControl.Controls.Add(this.rbtMocDinhKi);
            this.panelControl.Controls.Add(this.gbGiaoDichDinhKi);
            this.panelControl.Controls.Add(this.rbtMocThoiGian);
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(370, 727);
            this.panelControl.TabIndex = 0;
            // 
            // gbGiaoDichThoiGian
            // 
            this.gbGiaoDichThoiGian.Controls.Add(this.dtpNgayKetThuc);
            this.gbGiaoDichThoiGian.Controls.Add(this.label1);
            this.gbGiaoDichThoiGian.Controls.Add(this.label3);
            this.gbGiaoDichThoiGian.Controls.Add(this.dtpNgayBatDau);
            this.gbGiaoDichThoiGian.Location = new System.Drawing.Point(15, 349);
            this.gbGiaoDichThoiGian.Name = "gbGiaoDichThoiGian";
            this.gbGiaoDichThoiGian.Size = new System.Drawing.Size(338, 256);
            this.gbGiaoDichThoiGian.TabIndex = 10;
            this.gbGiaoDichThoiGian.TabStop = false;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(24, 184);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(300, 40);
            this.dtpNgayKetThuc.TabIndex = 109;
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn khoảng thời gian bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Chọn khoảng thời gian kết thúc";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(24, 73);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(300, 40);
            this.dtpNgayBatDau.TabIndex = 107;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // rbtMocDinhKi
            // 
            this.rbtMocDinhKi.AutoSize = true;
            this.rbtMocDinhKi.Location = new System.Drawing.Point(15, 60);
            this.rbtMocDinhKi.Name = "rbtMocDinhKi";
            this.rbtMocDinhKi.Size = new System.Drawing.Size(191, 24);
            this.rbtMocDinhKi.TabIndex = 4;
            this.rbtMocDinhKi.TabStop = true;
            this.rbtMocDinhKi.Text = "Chọn theo mốc định kì";
            this.rbtMocDinhKi.UseVisualStyleBackColor = true;
            this.rbtMocDinhKi.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // gbGiaoDichDinhKi
            // 
            this.gbGiaoDichDinhKi.Controls.Add(this.label4);
            this.gbGiaoDichDinhKi.Controls.Add(this.cbbDinhKi);
            this.gbGiaoDichDinhKi.Location = new System.Drawing.Point(15, 90);
            this.gbGiaoDichDinhKi.Name = "gbGiaoDichDinhKi";
            this.gbGiaoDichDinhKi.Size = new System.Drawing.Size(338, 179);
            this.gbGiaoDichDinhKi.TabIndex = 3;
            this.gbGiaoDichDinhKi.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chọn mốc định kì";
            // 
            // cbbDinhKi
            // 
            this.cbbDinhKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDinhKi.FormattingEnabled = true;
            this.cbbDinhKi.Location = new System.Drawing.Point(24, 76);
            this.cbbDinhKi.Name = "cbbDinhKi";
            this.cbbDinhKi.Size = new System.Drawing.Size(294, 40);
            this.cbbDinhKi.TabIndex = 8;
            this.cbbDinhKi.SelectedIndexChanged += new System.EventHandler(this.cbbDinhKi_SelectedIndexChanged);
            // 
            // rbtMocThoiGian
            // 
            this.rbtMocThoiGian.AutoSize = true;
            this.rbtMocThoiGian.Location = new System.Drawing.Point(15, 319);
            this.rbtMocThoiGian.Name = "rbtMocThoiGian";
            this.rbtMocThoiGian.Size = new System.Drawing.Size(229, 24);
            this.rbtMocThoiGian.TabIndex = 3;
            this.rbtMocThoiGian.TabStop = true;
            this.rbtMocThoiGian.Text = "Chọn theo khoảng thời gian";
            this.rbtMocThoiGian.UseVisualStyleBackColor = true;
            this.rbtMocThoiGian.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLoad.Location = new System.Drawing.Point(371, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1546, 727);
            this.panelLoad.TabIndex = 1;
            // 
            // ChiTietSoGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 727);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietSoGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietSoGiaoDich";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiTietSoGiaoDich_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.gbGiaoDichThoiGian.ResumeLayout(false);
            this.gbGiaoDichThoiGian.PerformLayout();
            this.gbGiaoDichDinhKi.ResumeLayout(false);
            this.gbGiaoDichDinhKi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.RadioButton rbtMocDinhKi;
        private System.Windows.Forms.RadioButton rbtMocThoiGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGiaoDichThoiGian;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.GroupBox gbGiaoDichDinhKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDinhKi;
    }
}