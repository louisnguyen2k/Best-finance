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
    public partial class DoiMatKhau : Form
    {
        /*PROPERTY*/
        // @id_User: Tên user cần đổi mật khẩu 
        public string id_User;
        public DoiMatKhau(string id)
        {
            id_User = id;
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            tbTenTK.Text = id_User;
        }

        /* Sự kiện click vào button thoát */
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Sự kiện click vào button OK */
        private void btOk_Click(object sender, EventArgs e)
        {
            string mk_cu = tbMatKhauCu.Text;
            string mk_moi1 = tbMatKhauMoi1.Text;
            string mk_moi2 = tbMatKhauMoi2.Text;


            if (mk_cu == string.Empty || mk_moi1 == string.Empty || mk_moi2 == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường thông tin !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Change_Passwork(mk_cu, mk_moi1, mk_moi2);

            
        }

        /* Sự kiện khi admin ấn đổi mật khẩu */
        void Change_Passwork(string mk_cu, string mk_moi1, string mk_moi2)
        {
            string query = @"SELECT COUNT(*) FROM TaiKhoan
                                WHERE taikhoan ='" + id_User + "' AND matkhau = '" + mk_cu + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DB.conn.Close();

            if (result != 0) // CASE-LV1: Nhập đúng mật khẩu cũ
            {
                if (mk_moi1 == mk_moi2) // CASE-LV2: Trùng mật khẩu mới
                {
                    DialogResult change_pass = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (change_pass == DialogResult.Yes) // CASE-LV3: Đổi mật khẩu
                    {
                        string change_pass_query = "UPDATE TaiKhoan SET matkhau = '" + mk_moi1 + "' WHERE taikhoan = '" + id_User + "'";
                        DB.conn.Open();
                        try
                        {
                            SqlCommand cmd_change_pass = new SqlCommand(change_pass_query, DB.conn);
                            cmd_change_pass.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear_password();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi !,\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            DB.conn.Close();
                        }
                    }
                    // else{} /* Không đổi mật khẩu */
                }
                else // CASE-LV2: Không trùng mật khẩu mới
                {
                    MessageBox.Show("Mật khẩu mới không trùng nhau, vui lòng nhập lại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_password();
                }
            }
            else // CASE-LV1: Nhập sai mật khẩu cũ
            {
                MessageBox.Show("Mật khẩu cũ không chính xác !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear_password();
            }
        }



        /* Xóa text các textbox mật khẩu */
        private void clear_password()
        {
            tbMatKhauCu.Text = string.Empty;
            tbMatKhauMoi1.Text = string.Empty;
            tbMatKhauMoi2.Text = string.Empty;
        }
    }
}
