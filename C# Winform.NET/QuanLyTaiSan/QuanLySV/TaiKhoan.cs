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
using System.IO;


namespace QuanLySV
{
    public partial class TaiKhoan : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        private string IDUser;
        private MenuADMIN root;

        public TaiKhoan(string id, MenuADMIN father)
        {
            InitializeComponent();
            IDUser = id;
            root = father;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            showMenu();
            lbName.Text = getName();
            getPicture();
        }






        private void btQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            showLoad1();

            panelLoad1.Controls.Clear();
            QuanLyTaiKhoan fr = new QuanLyTaiKhoan(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void btViCuaToi_Click(object sender, EventArgs e)
        {
            showLoad1();

            panelLoad1.Controls.Clear();
            Vi fr = new Vi(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        private void btDanhMucTaiSan_Click(object sender, EventArgs e)
        {
            showLoad1();

            panelLoad1.Controls.Clear();
            DanhMucTaiSan fr = new DanhMucTaiSan(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void btSoNo_Click(object sender, EventArgs e)
        {
            showLoad1();

            panelLoad1.Controls.Clear();
            SoNo fr = new SoNo(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        private void btDSNguoiQuen_Click(object sender, EventArgs e)
        {
            showLoad1();

            panelLoad1.Controls.Clear();
            DSNguoiQuen fr = new DSNguoiQuen(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        private void btGioiThieu_Click(object sender, EventArgs e)
        {
            FormDangPhatTrien dpt = new FormDangPhatTrien();
            dpt.ShowDialog();
            dpt.Close();
        }






        public void LoadForm2(Form fr)
        {
            showLoad2();

            panelLoad2.Controls.Clear();
            panelLoad2.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }



        public void showMenu()
        {
            panelLoad1.Hide();
            panelLoad2.Hide();
            panelMenu.Show();
            lbName.Text = getName();
            getPicture();
        }
        public void showLoad1()
        {
            panelLoad1.Show();
            panelLoad2.Hide();
            panelMenu.Hide();
        }

        public void showLoad2()
        {
            panelLoad2.Show();
            panelLoad1.Hide();
            panelMenu.Hide();
        }


        public void Logout()
        {
            root.Logout();
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


        /* Load ảnh từ DB lên Form*/
        void getPicture()
        {
            string query = "SELECT img FROM TaiKhoan WHERE taikhoan = '" + IDUser + "'";
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                byte[] link = (byte[])cmd.ExecuteScalar();

                MemoryStream stream = new MemoryStream(link.ToArray());

                Image image = Image.FromStream(stream);
                if (image == null)
                    return;
                rpbUser.Image = image;
            }
            catch (Exception e)
            {
                return;
            }
            finally
            {
                DB.conn.Close();
            }
        }

        
    }
}
