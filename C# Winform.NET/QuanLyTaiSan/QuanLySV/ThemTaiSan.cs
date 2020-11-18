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
using System.Drawing.Imaging;
using System.IO;

namespace QuanLySV
{
    public partial class ThemTaiSan : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        public string IDUser;


        public ThemTaiSan(string id)
        {
            InitializeComponent();
            IDUser = id;
        }

        private void ThemTaiSan_Load(object sender, EventArgs e)
        {
            tbSoLuong.Text = "0";
            tbGiaTri.Text = "0.0";
        }

        private void llbThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llbThem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ten = tbTen.Text;
            string so_luong = tbSoLuong.Text;
            string gia_tri = tbGiaTri.Text;
            string mo_ta = tbMoTa.Text;
            byte[] img = ImageTobByArray(pbAnhTaiSan.Image);

            if (ten == string.Empty || so_luong == string.Empty || gia_tri == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO TaiSan(ten_tai_san, so_luong, tri_gia, mo_ta, img, taikhoan)
                                    VALUES(N'"+ ten +"', "+ so_luong +", "+ gia_tri + ", N'"+ mo_ta + "', @img , '"+ IDUser +"')";
            



            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm tài sản thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài sản thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }

        private string nameFile; // Lưu tên file được chọn 
        /*Sự kiện chọn ảnh để thay đổi*/
        private void btThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.InitialDirectory = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFile.FileName;
                if (string.IsNullOrEmpty(nameFile))
                    return;
                Image myImage = Image.FromFile(nameFile);
                pbAnhTaiSan.Image = myImage;
            }
        }

        /*Chuyển ảnh thành byte*/
        byte[] ImageTobByArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }




        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
