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
    public partial class ChiTietGiaoDich : Form
    {
        private string id_giaodich;
        private int loaigiaodich; // 1: tài chính - 2: tài sản
        private string color_money;
        public ChiTietGiaoDich(string idgd, int loaigd, string color)
        {
            InitializeComponent();
            id_giaodich = idgd;
            loaigiaodich = loaigd;
            color_money = color;
        }
        private void ChiTietGiaoDich_Load(object sender, EventArgs e)
        {
            getDataGiaoDichTaiSan();

            if(loaigiaodich == 0)
            {
                getDataGiaoDichTaiChinh();
            }
            else // 1
            {
                getDataGiaoDichTaiSan();
            }

            lbMoney.ForeColor = color_money == "0" ? Color.ForestGreen : Color.Red;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc muốn xóa giao dịch này !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.No)
            {
                return;
            }

            string query = "";
            if (loaigiaodich == 0)
            {
                query = @"DELETE GiaoDichTaiChinh WHERE ma_giao_dich = '"+ id_giaodich + "'";
            }
            else
            {
                query = @"DELETE GiaoDichTaiSan WHERE ma_giao_dich = '" + id_giaodich + "'";
            }
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại !, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }


        void getDataGiaoDichTaiChinh()
        {
            string query = @"SELECT LoaiGiaoDich.img, LoaiGiaoDich.ten_loai_gd, GiaoDichTaiChinh.ghi_chu,NguoiQuen.ten_nguoi_quen , GiaoDichTaiChinh.so_tien, GiaoDichTaiChinh.thoi_gian, VI.img, VI.ten_vi
                                FROM GiaoDichTaiChinh, VI, LoaiGiaoDich, NguoiQuen
                                WHERE GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                                AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen
                                AND GiaoDichTaiChinh.ma_giao_dich = " + id_giaodich + "";
            string imgGiaoDich = "", tenGiaoDich = "", moTa = "", tenNguoiQuen = "", soTien = "", thoiGian = "", imgVi = "", tenVi = "";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                imgGiaoDich = rd[0].ToString();
                tenGiaoDich = rd[1].ToString();
                moTa = rd[2].ToString();
                tenNguoiQuen = rd[3].ToString();
                soTien = rd[4].ToString();
                thoiGian = rd[5].ToString();
                imgVi = rd[6].ToString();
                tenVi = rd[7].ToString();
            }
            DB.conn.Close();
            pbImgGiaoDich.Image = Commom.getImage(imgGiaoDich);
            lbTenGiaoDich.Text = tenGiaoDich;
            lbDescription.Text = moTa + " (" + tenNguoiQuen + ")";
            lbMoney.Text = Commom.getMoneyStr(soTien);
            string[] l = thoiGian.Split(' ');
            lbTime.Text = l[0];
            pbImgVi.Image = Commom.getImage(imgVi);
            lbTenVi.Text = tenVi;

        }

        void getDataGiaoDichTaiSan()
        {
            string query = @"SELECT LoaiGiaoDich.img, LoaiGiaoDich.ten_loai_gd, GiaoDichTaiSan.ghi_chu, TaiSan.ten_tai_san, (GiaoDichTaiSan.so_luong * TaiSan.tri_gia), GiaoDichTaiSan.thoi_gian, VI.img, VI.ten_vi, GiaoDichTaiSan.so_luong
                                FROM GiaoDichTaiSan, VI, LoaiGiaoDich, TaiSan
                                WHERE GiaoDichTaiSan.ma_vi = VI.ma_vi
                                AND GiaoDichTaiSan.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                                AND GiaoDichTaiSan.ma_tai_san = TaiSan.ma_tai_san
                                AND GiaoDichTaiSan.ma_giao_dich = " + id_giaodich + "";
            string imgGiaoDich = "", tenGiaoDich = "", moTa = "", tenTaiSan = "", soTien = "", thoiGian = "", imgVi = "", tenVi = "", soLuong ="";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                imgGiaoDich = rd[0].ToString();
                tenGiaoDich = rd[1].ToString();
                moTa = rd[2].ToString();
                tenTaiSan = rd[3].ToString();
                soTien = rd[4].ToString();
                thoiGian = rd[5].ToString();
                imgVi = rd[6].ToString();
                tenVi = rd[7].ToString();
                soLuong = rd[8].ToString();
            }
            DB.conn.Close();
            pbImgGiaoDich.Image = Commom.getImage(imgGiaoDich);
            lbTenGiaoDich.Text = tenGiaoDich;
            string[] l = soLuong.Split('.');


            lbDescription.Text = moTa + " (" + l[0] + "*" + tenTaiSan + ")";
            lbMoney.Text = Commom.getMoneyStr(soTien);
            l = thoiGian.Split(' ');
            lbTime.Text = l[0];
            pbImgVi.Image = Commom.getImage(imgVi);
            lbTenVi.Text = tenVi;
        }

        
    }
}
