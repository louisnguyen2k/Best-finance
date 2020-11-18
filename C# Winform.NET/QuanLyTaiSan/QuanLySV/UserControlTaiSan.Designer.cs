namespace QuanLySV
{
    partial class UserControlTaiSan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTongGiaTri = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 122);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(198, 35);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(93, 19);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "12,345,000 đ";
            this.labelValue.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.labelValue.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.labelValue.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(142, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 26);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Tủ lạnh";
            this.labelName.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giá trị:";
            this.label1.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.label1.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng:";
            this.label2.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.label2.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(216, 65);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(17, 19);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "5";
            this.labelCount.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.labelCount.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.labelCount.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // labelTongGiaTri
            // 
            this.labelTongGiaTri.AutoSize = true;
            this.labelTongGiaTri.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongGiaTri.Location = new System.Drawing.Point(229, 94);
            this.labelTongGiaTri.Name = "labelTongGiaTri";
            this.labelTongGiaTri.Size = new System.Drawing.Size(17, 19);
            this.labelTongGiaTri.TabIndex = 12;
            this.labelTongGiaTri.Text = "5";
            this.labelTongGiaTri.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.labelTongGiaTri.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.labelTongGiaTri.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng giá trị:";
            this.label5.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.label5.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // pbImg
            // 
            this.pbImg.Image = global::QuanLySV.Properties.Resources.product;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(122, 122);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 13;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.pbImg.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.pbImg.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            // 
            // UserControlTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelTongGiaTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelName);
            this.Name = "UserControlTaiSan";
            this.Size = new System.Drawing.Size(570, 125);
            this.Click += new System.EventHandler(this.UserControlTaiSan_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlTaiSan_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlTaiSan_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTongGiaTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbImg;
    }
}
