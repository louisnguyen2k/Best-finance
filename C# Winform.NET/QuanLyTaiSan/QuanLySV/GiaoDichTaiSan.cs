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
    public partial class GiaoDichTaiSan : Form
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @dictWallets: Dictionary object Wallets
        public string IDUser;
        Dictionary<string, CWallet> dictWallets;


        public GiaoDichTaiSan(string id)
        {
            InitializeComponent();
            IDUser = id;
        }

        private void GiaoDichTaiSan_Load(object sender, EventArgs e)
        {
            cbbVi.ValueMember = "Id";
            cbbVi.DisplayMember = "NameMoneyType";
            getDataVi();
            try
            {
                cbbVi.SelectedIndex = 0;
                getImageViTien();
            }
            catch (Exception) { }




            cbbLoaiGiaoDich.ValueMember = "MaLoaiGiaoDich";
            cbbLoaiGiaoDich.DisplayMember = "TenLoaiGiaoDich";
            getDataLoaiGiaoDich();


            cbbTaiSan.ValueMember = "Id";
            cbbTaiSan.DisplayMember = "Name";
            getDataTaiSan();
        }

        private void llbThemVi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string so_luong = tbSoLuong.Text;
            string thoi_gian = dtpNgayGiaoDich.Value.ToString();
            string ghi_chu = tbGhiChu.Text;


            if(cbbVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ví để giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id_vi = ((CWallet)cbbVi.SelectedItem).Id;


            if (cbbLoaiGiaoDich.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch để thực hiện giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id_loai_gd = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).MaLoaiGiaoDich;
            string name_loai_gd = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).TenLoaiGiaoDich;

            if (cbbTaiSan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tài sản để giao dịch hoặc thêm tài sản khác để giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id_tai_san = ((CTaiSan)cbbTaiSan.SelectedItem).Id;
            


            if (so_luong == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số lượng tài sản!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int so_luong_nhap = Convert.ToInt32(so_luong);
            int so_luong_so_huu = getSoLuongTaiSan(id_tai_san);
            if (so_luong_nhap > so_luong_so_huu && name_loai_gd == "Bán")
            {
                MessageBox.Show("vui lòng nhập số lượng tài sản phải nhỏ hơn hoặc bằng số lượng đang sở hữu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float ftien_trong_vi = ((CWallet)cbbVi.SelectedItem).getFMoney();
            float fso_tien = getMoneyTaiSan(id_tai_san) * float.Parse(so_luong);

            if (ftien_trong_vi < fso_tien && name_loai_gd == "Mua")
            {
                MessageBox.Show("Số tiền trong ví không đủ để thực hiện giao dịch, vui lòng thử lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string query = @"INSERT INTO GiaoDichTaiSan(ma_vi,ma_loai_gd, ma_tai_san, so_luong, thoi_gian, ghi_chu)
                            VALUES('"+ id_vi +"', '"+ id_loai_gd + "', '"+ id_tai_san + "', "+ so_luong + ", '"+ thoi_gian +"', N'"+ ghi_chu +"')";


            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm giao dịch thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();



                clearForm();
                getDataVi();
                getDataTaiSan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm giao dịch thất bại!, EX:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }

        private void btThemTaiSanKhac_Click(object sender, EventArgs e)
        {
            ThemTaiSan tts = new ThemTaiSan(IDUser);
            tts.ShowDialog();
            tts.Close();

            getDataTaiSan();

            cbbTaiSan.SelectedIndex = -1;
        }

        private void cbbVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVi.SelectedIndex == -1) return;
            getImageViTien();
        }

        private void cbbLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiGiaoDich.SelectedIndex == -1)
                return;
            getImageLoaiGiaoDich();
        }

        private void cbbTaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTaiSan.SelectedIndex == -1)
                return;
            getDataTaiSanGB();
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void getDataVi()
        {
            cbbVi.Items.Clear();
            dictWallets = new Dictionary<string, CWallet>();

            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CWallet wl = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                cbbVi.Items.Add(wl);
                dictWallets[wl.Id] = wl;
            }
            DB.conn.Close();
        }


        void getDataLoaiGiaoDich()
        {
            cbbLoaiGiaoDich.Items.Clear();

            string query = @"SELECT * FROM LoaiGiaoDich
                            WHERE ma_nhom_gd = 4";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CLoaiGiaoDich ngd = new CLoaiGiaoDich(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
                cbbLoaiGiaoDich.Items.Add(ngd);
            }
            DB.conn.Close();
        }


        void getDataTaiSan()
        {
            cbbTaiSan.Items.Clear();

            string query = @"SELECT ma_tai_san, ten_tai_san, so_luong, tri_gia, mo_ta, img
                                FROM TaiSan
                                WHERE taikhoan = 'admin'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CTaiSan ngd = new CTaiSan(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), (byte[])rd[5]);
                cbbTaiSan.Items.Add(ngd);
            }
            DB.conn.Close();
        }

        float getMoneyTaiSan(string id)
        {
            string query = @"SELECT tri_gia FROM TaiSan
                            WHERE ma_tai_san = '"+ id +"'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            DB.conn.Close();
            return result;
        }


        int getSoLuongTaiSan(string id)
        {
            string query = @"SELECT so_luong FROM TaiSan
                                WHERE ma_tai_san = '"+ id +"'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DB.conn.Close();
            return result;
        }


        void getImageLoaiGiaoDich()
        {
            string name_img = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).Img;
            pbLoaiGiaoDich.Image = Commom.getImage(name_img);
        }

        void getImageViTien()
        {
            string name_img = ((CWallet)cbbVi.SelectedItem).Img;
            pbVi.Image = Commom.getImage(name_img);
        }

        void getDataTaiSanGB()
        {
            getImageTaiSan();
            lbNameSP.Text = ((CTaiSan)cbbTaiSan.SelectedItem).Name;
            lbCountSP.Text = ((CTaiSan)cbbTaiSan.SelectedItem).Count;
            lbValueSP.Text = Commom.getMoneyStr(((CTaiSan)cbbTaiSan.SelectedItem).Value);
        }
        void getImageTaiSan()
        {
            pbImgTaiSan.Image = ((CTaiSan)cbbTaiSan.SelectedItem).getImage();
        }

        void clearForm()
        {
            clearTaiSanGB();
            cbbLoaiGiaoDich.SelectedIndex = -1;
            pbLoaiGiaoDich.Image = null;
            cbbTaiSan.SelectedIndex = - 1;
            tbSoLuong.Text = string.Empty;
            tbGhiChu.Text = string.Empty;
        }

        void clearTaiSanGB()
        {
            pbImgTaiSan.Image = null;
            lbNameSP.Text = string.Empty;
            lbCountSP.Text = string.Empty;
            lbValueSP.Text = string.Empty;
        }
    }
}
