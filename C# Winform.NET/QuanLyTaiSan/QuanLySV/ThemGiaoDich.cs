using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class ThemGiaoDich : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        public string IDUser;
        public MenuADMIN root;
        public ThemGiaoDich(string id, MenuADMIN father)
        {
            InitializeComponent();
            IDUser = id;
            root = father;
        }

        

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            GiaoDichTaiChinh fr = new GiaoDichTaiChinh(IDUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void btGiaoDichTaiSan_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            GiaoDichTaiSan fr = new GiaoDichTaiSan(IDUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }
    }
}
