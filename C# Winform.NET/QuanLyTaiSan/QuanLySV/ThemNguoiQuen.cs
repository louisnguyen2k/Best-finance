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
    public partial class ThemNguoiQuen : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        public string IDUser;
        public ThemNguoiQuen(string id)
        {
            InitializeComponent();
            IDUser = id;
        }


        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void llbThem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add();
        }


        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void add()
        {
            string name = tbName.Text;
            string sdt = tbSDT.Text;
            string addr = tbDiaChi.Text;

            if (name == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập ít nhất trường tên người quen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"INSERT INTO NguoiQuen(ten_nguoi_quen, sdt, dia_chi, so_tien, taikhoan) VALUES
                                (N'" + name + "', '" + sdt + "', N'" + addr + "', 0, '" + IDUser + "')";


            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }
    }
}
