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
    public partial class ChiTietNguoiQuen : Form
    {
        /*PROPERTY*/
        // @IdNguoiQuen: ID tài khoản của user đăng nhập thành công.
        public string IdNguoiQuen;


        /*----------------------*/
        string name;
        string sotien;
        string sdt;
        string diachi;
        /*----------------------*/

        public ChiTietNguoiQuen(string id)
        {
            InitializeComponent();
            IdNguoiQuen = id;
        }

        private void ChiTietNguoiQuen_Load(object sender, EventArgs e)
        {
            groupBoxInfor.Show();
            groupBoxEdit.Hide();
            panelSuaXoa.Show();
            panelLuuHuy.Hide();
            getData();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

       

        private void btSua_Click(object sender, EventArgs e)
        {
            groupBoxInfor.Hide();
            groupBoxEdit.Show();
            panelSuaXoa.Hide();
            panelLuuHuy.Show();
            //
            tbName.Text = name;
            tbSoTien.Text = sotien;
            tbSDT.Text = sdt;
            tbDiaChi.Text = diachi;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = @"DELETE NguoiQuen WHERE ma_nguoi_quen = '"+ IdNguoiQuen +"'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            if (tbName.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên người quen!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;
            if(tbSoTien.Text == string.Empty)
                query = @"UPDATE NguoiQuen SET ten_nguoi_quen = N'" + tbName.Text + "', so_tien = 0, sdt = '" + tbSDT.Text + "', dia_chi = N'" + tbDiaChi.Text + "' " +
                "WHERE ma_nguoi_quen = '" + IdNguoiQuen + "'";
            else
                query = @"UPDATE NguoiQuen SET ten_nguoi_quen = N'"+ tbName.Text +"', so_tien = "+ tbSoTien.Text +", sdt = '"+ tbSDT.Text +"', dia_chi = N'"+ tbDiaChi.Text +"' " +
                "WHERE ma_nguoi_quen = '"+ IdNguoiQuen +"'";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                groupBoxInfor.Show();
                groupBoxEdit.Hide();
                panelSuaXoa.Show();
                panelLuuHuy.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                DB.conn.Close();
            }
            getData();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            groupBoxInfor.Show();
            groupBoxEdit.Hide();
            panelSuaXoa.Show();
            panelLuuHuy.Hide();
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
        void getData()
        {
            string query = @"SELECT ten_nguoi_quen, so_tien, sdt, dia_chi
                            FROM NguoiQuen
                            WHERE ma_nguoi_quen = "+ IdNguoiQuen +"";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    name = rd[0].ToString() is DBNull ? string.Empty : rd[0].ToString();
                    lbName.Text = name;

                    sotien = rd[1].ToString() is DBNull ? string.Empty : rd[1].ToString();
                    lbSoTien.Text = Commom.getMoneyStr(sotien) + " VND";

                    sdt = rd[2].ToString() is DBNull ? string.Empty : rd[2].ToString();
                    lbSDT.Text = sdt;

                    diachi = rd[3].ToString() is DBNull ? string.Empty : rd[3].ToString();
                    lbDiaChi.Text = diachi;
                }
            }
            catch (Exception ex)
            {

            }
            DB.conn.Close();
        }
        
    }
}
