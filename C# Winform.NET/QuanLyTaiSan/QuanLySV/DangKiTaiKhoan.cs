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
    public partial class DangKiTaiKhoan : Form
    {
        public DangKiTaiKhoan()
        {
            InitializeComponent();
        }
        void clearMK()
        {
            tbMK1.Text = string.Empty;
            tbMK2.Text = string.Empty;
        }
        void clearTB()
        {
            tbTenTK.Text = string.Empty;
            tbTenNguoiDung.Text = string.Empty;
            clearMK();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangKi_Click_1(object sender, EventArgs e)
        {
            string tk = tbTenTK.Text;
            string name = tbTenNguoiDung.Text;
            string mk1 = tbMK1.Text;
            string mk2 = tbMK2.Text;
            if (tk == string.Empty ||
                name == string.Empty ||
                mk1 == string.Empty ||
                mk2 == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Wanning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (mk1 != mk2)
            {
                MessageBox.Show("Hai mật khẩu không trùng nhau!", "Wanning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearMK();
                return;
            }



            string query = @"INSERT TaiKhoan(taikhoan, name, matkhau) 
                        VALUES ('" + tk + "',N'" + name + "','" + mk1 + "')";

            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng kí tài khoản thành công!", "Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên tài khoản này đã có người dùng, vui lòng dùng mã khác!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.conn.Close();
            }
        }

    }
}
