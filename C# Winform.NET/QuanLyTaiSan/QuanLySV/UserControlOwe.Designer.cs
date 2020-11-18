namespace QuanLySV
{
    partial class UserControlOwe
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbLoaiNhanTra = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbSoGiaoDich = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(14, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(183, 27);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nguyễn Hiệp Lộc";
            this.lbName.MouseEnter += new System.EventHandler(this.UserControlOwe_MouseEnter);
            this.lbName.MouseLeave += new System.EventHandler(this.UserControlOwe_MouseLeave);
            // 
            // lbLoaiNhanTra
            // 
            this.lbLoaiNhanTra.AutoSize = true;
            this.lbLoaiNhanTra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNhanTra.ForeColor = System.Drawing.Color.Gray;
            this.lbLoaiNhanTra.Location = new System.Drawing.Point(15, 57);
            this.lbLoaiNhanTra.Name = "lbLoaiNhanTra";
            this.lbLoaiNhanTra.Size = new System.Drawing.Size(139, 22);
            this.lbLoaiNhanTra.TabIndex = 1;
            this.lbLoaiNhanTra.Text = "Chưa nhận được";
            this.lbLoaiNhanTra.MouseEnter += new System.EventHandler(this.UserControlOwe_MouseEnter);
            this.lbLoaiNhanTra.MouseLeave += new System.EventHandler(this.UserControlOwe_MouseLeave);
            // 
            // lbSoTien
            // 
            this.lbSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.ForeColor = System.Drawing.Color.Black;
            this.lbSoTien.Location = new System.Drawing.Point(324, 53);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(231, 27);
            this.lbSoTien.TabIndex = 28;
            this.lbSoTien.Text = "20,000.00";
            this.lbSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSoTien.MouseEnter += new System.EventHandler(this.UserControlOwe_MouseEnter);
            this.lbSoTien.MouseLeave += new System.EventHandler(this.UserControlOwe_MouseLeave);
            // 
            // lbSoGiaoDich
            // 
            this.lbSoGiaoDich.AutoSize = true;
            this.lbSoGiaoDich.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoGiaoDich.ForeColor = System.Drawing.Color.Gray;
            this.lbSoGiaoDich.Location = new System.Drawing.Point(469, 16);
            this.lbSoGiaoDich.Name = "lbSoGiaoDich";
            this.lbSoGiaoDich.Size = new System.Drawing.Size(98, 22);
            this.lbSoGiaoDich.TabIndex = 29;
            this.lbSoGiaoDich.Text = "1 giao dịch";
            this.lbSoGiaoDich.MouseEnter += new System.EventHandler(this.UserControlOwe_MouseEnter);
            this.lbSoGiaoDich.MouseLeave += new System.EventHandler(this.UserControlOwe_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(19, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 2);
            this.panel1.TabIndex = 30;
            // 
            // UserControlOwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSoGiaoDich);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbLoaiNhanTra);
            this.Controls.Add(this.lbName);
            this.Name = "UserControlOwe";
            this.Size = new System.Drawing.Size(570, 100);
            this.MouseEnter += new System.EventHandler(this.UserControlOwe_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlOwe_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLoaiNhanTra;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbSoGiaoDich;
        private System.Windows.Forms.Panel panel1;
    }
}
