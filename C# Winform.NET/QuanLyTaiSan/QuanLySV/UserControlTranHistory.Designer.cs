namespace QuanLySV
{
    partial class UserControlTranHistory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.rpbImg = new QuanLySV.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(15, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 2);
            this.panel2.TabIndex = 16;
            this.panel2.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(165, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 33);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Cà phê";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbName.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.lbName.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.lbName.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Gray;
            this.lbTime.Location = new System.Drawing.Point(166, 51);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(167, 22);
            this.lbTime.TabIndex = 23;
            this.lbTime.Text = "17/11/2020, Thứ ba";
            this.lbTime.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.lbTime.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.lbTime.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Gray;
            this.lbDescription.Location = new System.Drawing.Point(166, 87);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(530, 50);
            this.lbDescription.TabIndex = 24;
            this.lbDescription.Text = "Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô tả Mô " +
    "tả Mô tả Mô tả";
            this.lbDescription.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.lbDescription.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.lbDescription.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // lbMoney
            // 
            this.lbMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.Red;
            this.lbMoney.Location = new System.Drawing.Point(716, 91);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(181, 22);
            this.lbMoney.TabIndex = 25;
            this.lbMoney.Text = "4,600.00";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMoney.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.lbMoney.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.lbMoney.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // rpbImg
            // 
            this.rpbImg.Image = global::QuanLySV.Properties.Resources.different1;
            this.rpbImg.Location = new System.Drawing.Point(15, 15);
            this.rpbImg.Name = "rpbImg";
            this.rpbImg.Size = new System.Drawing.Size(120, 120);
            this.rpbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rpbImg.TabIndex = 22;
            this.rpbImg.TabStop = false;
            this.rpbImg.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.rpbImg.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.rpbImg.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            // 
            // UserControlTranHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.rpbImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbName);
            this.Name = "UserControlTranHistory";
            this.Size = new System.Drawing.Size(900, 150);
            this.Click += new System.EventHandler(this.UserControlTranHistory_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlTranHistory_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlTranHistory_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private RoundPictureBox rpbImg;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbMoney;
    }
}
