using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySV
{
    public partial class MenuADMIN : Form
    {

        /*PROPERTY*/
        // @NameUser: Tên tài khoản của user đăng nhập thành công.
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @Date: Thời gian hiện tại của hệ thống.
        public string NameUser;
        public string IDUser;
        public string Date;
        /**/

        /* ------------- Các sự kiện hệ thống ------------- */

        // Hàm khởi tạo
        public MenuADMIN()
        {
            Date = DateTime.Now.ToString("dd-MM-yyyy");
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void MenuADMIN_Load(object sender, EventArgs e)
        {
            lbDate.Text = this.Date;
            Open_Login();
        }

        /*  Sự kiện đóng form Exit(Thoát) */
        private void MenuADMIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            */
        }

        /*  Sự kiện click label_link tương tự sự kiện click nút Logout(đăng xuất) */
        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        /*  Sự kiện click label_link tương tự sự kiện click nút Exit(Thoát) */
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Exit();
        }


        /* Sự kiện click button Sổ giao dịch */
        private void btSoGiaoDich_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            SoGiaoDich fr = new SoGiaoDich(IDUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelMenu.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        /* Sự kiện click button Báo cáo */
        private void btBaoCao_Click(object sender, EventArgs e)
        {

        }

        /* Sự kiện click button Thêm giao dịch mới */
        private void btThemGiaoDich_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            ThemGiaoDich fr = new ThemGiaoDich(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelMenu.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        /* Sự kiện click button Lập kế hoạch */
        private void btLapKeHoach_Click(object sender, EventArgs e)
        {

        }

        /* Sự kiện click button Tài khoản */
        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            TaiKhoan fr = new TaiKhoan(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelMenu.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }




        /*------------- Hàm sử lý các sự kiện -------------*/


        /* Hàm sử lý sự kiện đăng xuất */
        public void Logout()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Open_Login();
            }
        }

        /* Hàm sử lý sự kiệt thoát(đóng form) */
        void Exit()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /* Hàm trả về tên của người dùng theo ID */
        string getName()
        {
            string query = @"SELECT name FROM TaiKhoan
                    WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();

            string name = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);

                name = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            DB.conn.Close();

            return name;
        }









        /* ------------- Các hàm mở form mới ------------- */

        /* Hàm mở form đăng nhập và lấy id vừa đăng nhập gán cho id của form Menu */
        void Open_Login()
        {
            lbName.Text = "";
            llbLogOut.Hide();
            panelListButton.Hide();
            panelMenu.Controls.Clear();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            if (dn.LoginResult == DangNhap.LOGIN_FAILED)
            {
                this.Close();
            }
            else
            {
                this.IDUser = dn.IDUser; // gán id login NameUser vừa đăng nhập vào id Menu NameUser
                this.NameUser = getName();
                lbName.Text = this.NameUser;
                llbLogOut.Show();
                panelListButton.Show();
                dn.Close();
                MessageBox.Show("Hello " + NameUser + "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Hàm mở form đổi mật khẩu */
        void Open_Change_Passwork()
        {
            DoiMatKhau dmk = new DoiMatKhau(IDUser);
            dmk.ShowDialog();
            dmk.Close();
        }






        /*----------------- Run text -----------------*/


        //537, 48
        int x = 12, y = 6, a = 1;

        

        Random rd = new Random();
        // Hàm điều chỉnh location label
        private void runText_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a * 1;
                labelRun.Location = new Point(x, y);
                if (x > 745)
                {
                    a = -1;
                    labelRun.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
                if (x < 12)
                {
                    a = 1;
                    labelRun.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
