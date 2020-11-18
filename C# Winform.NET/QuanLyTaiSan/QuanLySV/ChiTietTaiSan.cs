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
using System.Drawing.Imaging;

namespace QuanLySV
{
    public partial class ChiTietTaiSan : Form
    {
        // @id: Mã tài sản
        // @TaiSan: Đối tượng tài sản
        // @nameFile: Lưu tên file được chọn load ảnh
        private string Id;
        private CTaiSan TaiSan;
        private string nameFile;
        public ChiTietTaiSan(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void ChiTietTaiSan_Load(object sender, EventArgs e)
        {
            getData();
            gbDetail.Show();
            gbEdit.Hide();
            btThemAnh.Hide();

        }
        private void llbThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void llbSua_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            assignData();
            gbDetail.Hide();
            gbEdit.Show();
            btThemAnh.Show();
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            string name = tbTen.Text;
            string count = tbSoLuong.Text;
            string value = tbGiaTri.Text;
            string description = tbMoTa.Text;
            byte[] img = ImageTobByArray(pbAnhTaiSan.Image);

            if(name == string.Empty || count == string.Empty || value == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"UPDATE TaiSan SET ten_tai_san = N'"+ name +"', so_luong = "+ count +", tri_gia = "+ value +", mo_ta = N'"+ description +"', img = @img WHERE ma_tai_san = '"+Id+"'";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();

                getData();
                gbDetail.Show();
                gbEdit.Hide();
                btThemAnh.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            gbDetail.Show();
            gbEdit.Hide();
            btThemAnh.Hide();
            pbAnhTaiSan.Image = TaiSan.getImage();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = @"DELETE TaiSan WHERE ma_tai_san = '"+ Id +"'";

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
                MessageBox.Show("Xóa thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }
        
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




        void getData()
        {
            string query = @"SELECT ma_tai_san, ten_tai_san, so_luong, tri_gia, mo_ta, img
                        FROM TaiSan
                        WHERE ma_tai_san = "+ Id + "";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                TaiSan = new CTaiSan(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), (byte[])rd[5]);
            }
            DB.conn.Close();

            lbName.Text = TaiSan.Name;
            lbCount.Text = TaiSan.Count;
            lbValue.Text = Commom.getMoneyStr(TaiSan.Value);
            lbDescription.Text = TaiSan.Description;
            pbAnhTaiSan.Image = TaiSan.getImage();
        }

        void assignData()
        {
            tbTen.Text = TaiSan.Name;
            tbSoLuong.Text = TaiSan.Count;
            tbGiaTri.Text = TaiSan.Value;
            tbMoTa.Text = TaiSan.Description;
        }



        


        /*Chuyển ảnh thành byte*/
        byte[] ImageTobByArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }
    }
}
