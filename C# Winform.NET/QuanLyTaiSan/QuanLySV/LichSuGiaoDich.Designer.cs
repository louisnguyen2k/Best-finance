namespace QuanLySV
{
    partial class LichSuGiaoDich
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
            this.panelLaughFace = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panelLaughFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.Controls.Add(this.flowLayoutPanel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox.Location = new System.Drawing.Point(148, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1250, 727);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "     Lịch sử giao dịch";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.panelLaughFace);
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel.Location = new System.Drawing.Point(1, 27);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1248, 700);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panelLaughFace
            // 
            this.panelLaughFace.Controls.Add(this.label1);
            this.panelLaughFace.Controls.Add(this.pictureBox);
            this.panelLaughFace.Location = new System.Drawing.Point(3, 3);
            this.panelLaughFace.Name = "panelLaughFace";
            this.panelLaughFace.Size = new System.Drawing.Size(1242, 609);
            this.panelLaughFace.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::QuanLySV.Properties.Resources.laughing;
            this.pictureBox.Location = new System.Drawing.Point(493, 102);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Không có giao dịch nào";
            // 
            // LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1546, 727);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichSuGiaoDich";
            this.Text = "LichSuGiaoDich";
            this.Load += new System.EventHandler(this.LichSuGiaoDich_Load);
            this.groupBox.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelLaughFace.ResumeLayout(false);
            this.panelLaughFace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelLaughFace;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
    }
}