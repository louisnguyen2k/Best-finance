using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLySV
{
    public partial class GiaoDichTaiChinh : Form
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @dictWallets: Dictionary object Wallets
        public string IDUser;
        Dictionary<string, CWallet> dictWallets;

        public GiaoDichTaiChinh(string id)
        {
            InitializeComponent();
            IDUser = id;
        }

        private void GiaoDichTaiChinh_Load(object sender, EventArgs e)
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


            getDataNhomGiaoDich();
            cbbNhomGiaoDich.ValueMember = "MaNhom";
            cbbNhomGiaoDich.DisplayMember = "TenNhom";


            cbbLoaiGiaoDich.ValueMember = "MaLoaiGiaoDich";
            cbbLoaiGiaoDich.DisplayMember = "TenLoaiGiaoDich";


            panelNguoiQuen.Hide();
            
        }
        private void cbbVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVi.SelectedIndex == -1) return;
            getImageViTien();
        }

        private void cbbNhomGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhomGiaoDich.SelectedIndex == -1)
                return;
            getDataLoaiGiaoDich();
            pbLoaiGiaoDich.Image = null;

            string name = ((CNhomGiaoDich)cbbNhomGiaoDich.SelectedItem).TenNhom;
            if (name == "Đi vay/Cho vay")
            {
                panelNguoiQuen.Show();
            }
            else
                panelNguoiQuen.Hide();
            tbSoTien.Text = string.Empty;
            tbSoTien.Enabled = true;
        }
        private void cbbLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiGiaoDich.SelectedIndex == -1)
                return;
            getImageLoaiGiaoDich();

            string name = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).TenLoaiGiaoDich;
            string query;

            if (name == "Trả nợ")
            {
                query = @"SELECT NguoiQuen.ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi, GiaoDichTaiChinh.so_tien, GiaoDichTaiChinh.ma_giao_dich
                                        FROM NguoiQuen, GiaoDichTaiChinh, LoaiGiaoDich
                                        WHERE NguoiQuen.ma_nguoi_quen = GiaoDichTaiChinh.ma_nguoi_quen
                                        AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                                        AND NguoiQuen.taikhoan = '" + IDUser + "' " +
                                        "AND NguoiQuen.ma_nguoi_quen != " + Commom.clone_nguoi_quen + " " +
                                        "AND LoaiGiaoDich.ten_loai_gd = N'Đi vay'";
                getDataNguoiQuen(query, 1);


                cbbNguoiQuen.ValueMember = "MaGiaoDich";
                cbbNguoiQuen.DisplayMember = "TenTien";
            }
            else if (name == "Thu nợ")
            {
                query = @"SELECT NguoiQuen.ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi, GiaoDichTaiChinh.so_tien, GiaoDichTaiChinh.ma_giao_dich
                                        FROM NguoiQuen, GiaoDichTaiChinh, LoaiGiaoDich
                                        WHERE NguoiQuen.ma_nguoi_quen = GiaoDichTaiChinh.ma_nguoi_quen
                                        AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                                        AND NguoiQuen.taikhoan = '" + IDUser + "' " +
                                        "AND NguoiQuen.ma_nguoi_quen != " + Commom.clone_nguoi_quen + " " +
                                        "AND LoaiGiaoDich.ten_loai_gd = N'Cho vay'";
                getDataNguoiQuen(query, 2);


                cbbNguoiQuen.ValueMember = "MaGiaoDich";
                cbbNguoiQuen.DisplayMember = "TenTien";

            }
            else // Đi vay & Cho vay
            {
                query = @"SELECT ma_nguoi_quen, ten_nguoi_quen, sdt, dia_chi
                                    FROM NguoiQuen
                                    WHERE taikhoan = '" + IDUser + "'" +
                                    "AND NguoiQuen.ma_nguoi_quen != " + Commom.clone_nguoi_quen + "";
                getDataNguoiQuen(query, 3);


                cbbNguoiQuen.ValueMember = "MaNguoiQuen";
                cbbNguoiQuen.DisplayMember = "TenTien";
            }
            tbSoTien.Text = string.Empty;
            tbSoTien.Enabled = true;
        }
        private void cbbLoaiGiaoDich_Click(object sender, EventArgs e)
        {
            if (cbbNhomGiaoDich.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn nhóm giao dịch trước!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //
        private void cbbNguoiQuen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNguoiQuen.SelectedIndex == -1) return;

            string name = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).TenLoaiGiaoDich;

            if (name == "Trả nợ")
            {
                string str_money = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).SoTien;
                float fmoney = float.Parse(str_money);

                decimal decimal_value = Math.Round(Convert.ToDecimal(fmoney), 2);
                tbSoTien.Text = decimal_value.ToString();
                tbSoTien.Enabled = false;
            }
            else if (name == "Thu nợ")
            {
                string str_money = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).SoTien;
                float fmoney = float.Parse(str_money);

                decimal decimal_value = Math.Round(Convert.ToDecimal(fmoney), 2);
                tbSoTien.Text = decimal_value.ToString();
                tbSoTien.Enabled = false;
            }
            else // Đi vay & Cho vay
            {
                tbSoTien.Enabled = true;
            }
        }

        private void llbThemVi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string so_tien = tbSoTien.Text;

            if (cbbVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ví để giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id_vi = ((CWallet)cbbVi.SelectedItem).Id;



            if (cbbNhomGiaoDich.SelectedIndex == -1)
            {
                MessageBox.Show("Vui chọn nhóm giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name_nhom_giao_dich = ((CNhomGiaoDich)cbbNhomGiaoDich.SelectedItem).TenNhom;



            if (cbbLoaiGiaoDich.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ten_loai_giao_dich = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).TenLoaiGiaoDich;
            string id_loai_giao_dich = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).MaLoaiGiaoDich;




            if (so_tien == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số tiền giao dịch!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tien_trong_vi = getTienTrongVi(id_vi);
            float ftien_giao_dich = float.Parse(so_tien);
            float ftien_trong_vi = float.Parse(tien_trong_vi);
            if (ftien_giao_dich > ftien_trong_vi && (name_nhom_giao_dich != "Khoản thu" || ten_loai_giao_dich == "Đi vay" || ten_loai_giao_dich == "Thu nợ"))
            {
                MessageBox.Show("Số tiền giao dịch phải nhỏ hơn hoặc bằng số tiền trong ví!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string time = dtpNgayGiaoDich.Value.ToString();
            string ghi_chu = tbGhiChu.Text;
            string query;


            if (name_nhom_giao_dich == "Đi vay/Cho vay")
            {
                if (cbbNguoiQuen.SelectedIndex == -1) // chọn người quen
                {
                    MessageBox.Show("Chọn người quen để thực hiện giao dịch vay/nợ !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string id_nguoi_quen = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).MaNguoiQuen;

                if (ten_loai_giao_dich == "Trả nợ")
                {
                    string ma_giao_dich = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).MaGiaoDich;
                    string id_vi_xoa = getMaVi(ma_giao_dich);
                    string loai_tien_vi_xoa = getLoaiTien(id_vi_xoa);
                    string loai_tien_vi = getLoaiTien(id_vi);
                    so_tien = Commom.ConvertMoney(loai_tien_vi_xoa, loai_tien_vi, float.Parse(so_tien));

                    query = @"INSERT INTO GiaoDichTaiChinh(ma_vi, ma_loai_gd, ma_nguoi_quen, so_tien, thoi_gian, ghi_chu) 
                        VALUES('" + id_vi + "', '" + id_loai_giao_dich + "', '" + id_nguoi_quen + "', " + so_tien + ", '" + time + "', N'" + ghi_chu + "')";
                    
                    del();
                }
                else if (ten_loai_giao_dich == "Thu nợ")
                {
                    string ma_giao_dich = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).MaGiaoDich;
                    string id_vi_xoa = getMaVi(ma_giao_dich);
                    string loai_tien_vi_xoa = getLoaiTien(id_vi_xoa);
                    string loai_tien_vi = getLoaiTien(id_vi);
                    so_tien = Commom.ConvertMoney(loai_tien_vi_xoa, loai_tien_vi, float.Parse(so_tien));

                    query = @"INSERT INTO GiaoDichTaiChinh(ma_vi, ma_loai_gd, ma_nguoi_quen, so_tien, thoi_gian, ghi_chu) 
                        VALUES('" + id_vi + "', '" + id_loai_giao_dich + "', '" + id_nguoi_quen + "', " + so_tien + ", '" + time + "', N'" + ghi_chu + "')";
                    
                    del();
                }
                else// Đi vay || Cho vay
                {

                    query = @"INSERT INTO GiaoDichTaiChinh(ma_vi, ma_loai_gd, ma_nguoi_quen, so_tien, thoi_gian, ghi_chu) 
                        VALUES('" + id_vi + "', '" + id_loai_giao_dich + "', '" + id_nguoi_quen + "', " + so_tien + ", '" + time + "', N'" + ghi_chu + "')";
                }
            }
            else // giao dịch khác vay/trả
            {
                query = @"INSERT INTO GiaoDichTaiChinh(ma_vi, ma_loai_gd, ma_nguoi_quen, so_tien, thoi_gian, ghi_chu) 
                        VALUES('" + id_vi + "', '" + id_loai_giao_dich + "', '" + Commom.clone_nguoi_quen + "', " + so_tien + ", '" + time + "', N'" + ghi_chu + "')";
            }





            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm giao dịch thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm giao dịch thất bại! EX:" +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.conn.Close();
            }
            getDataVi();

        }








        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }




        /* Lấy dữ liệu từ DB đổ lên List */
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

        void getDataNhomGiaoDich()
        {

            string query = @"SELECT * FROM NhomGiaoDich
                                WHERE ma_nhom_gd != 4";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CNhomGiaoDich ngd = new CNhomGiaoDich(rd[0].ToString(), rd[1].ToString());
                cbbNhomGiaoDich.Items.Add(ngd);
            }
            DB.conn.Close();
        }

        void getDataLoaiGiaoDich()
        {
            cbbLoaiGiaoDich.Items.Clear();
            string ma_loai_gd = ((CNhomGiaoDich)cbbNhomGiaoDich.SelectedItem).MaNhom;

            string query = @"SELECT * FROM LoaiGiaoDich
                                WHERE ma_nhom_gd = " + ma_loai_gd + "";
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


        void getDataNguoiQuen(string select_query, int type_query)
        {
            cbbNguoiQuen.Items.Clear();


            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(select_query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CNguoiQuen nq;
                if (type_query == 1 || type_query == 2)
                    nq = new CNguoiQuen(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString());
                else
                    nq = new CNguoiQuen(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), string.Empty);
                cbbNguoiQuen.Items.Add(nq);
            }
            DB.conn.Close();
        }


        string getTienTrongVi(string id)
        {
            string query = @"SELECT so_tien FROM VI
                            WHERE ma_vi = '" + id + "'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result is DBNull ? string.Empty : result;
        }

        void getImageViTien()
        {
            string name_img = ((CWallet)cbbVi.SelectedItem).Img;
            pbVi.Image = Commom.getImage(name_img);
            string type_money = ((CWallet)cbbVi.SelectedItem).Type;
            if (type_money == "VND")
                pbSoTien.Image = Commom.getImage("vnd.PNG");
            else
                pbSoTien.Image = Commom.getImage("usd.PNG");
        }

        void getImageLoaiGiaoDich()
        {
            string name_img = ((CLoaiGiaoDich)cbbLoaiGiaoDich.SelectedItem).Img;
            pbLoaiGiaoDich.Image = Commom.getImage(name_img);
        }

        void clearData()
        {
            cbbVi.SelectedIndex = 0;
            dtpNgayGiaoDich.Value = DateTime.Now;
            cbbNhomGiaoDich.SelectedIndex = -1;
            cbbLoaiGiaoDich.SelectedIndex = -1;
            tbSoTien.Text = string.Empty;
            cbbNguoiQuen.SelectedIndex = -1;
            panelNguoiQuen.Hide();
            tbGhiChu.Text = string.Empty;
        }

        string getLoaiTien(string id_vi)
        {
            string query = @"SELECT don_vi FROM VI
                    WHERE ma_vi = '"+id_vi+"'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        string getMaVi(string id_giao_dich)
        {
            string query = @"SELECT ma_vi FROM GiaoDichTaiChinh
                    WHERE ma_giao_dich = '"+id_giao_dich+"'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        // xóa giao dịch cho vay và đang nợ khỏi lịch sử.
        void del()
        {
            string ma_giao_dich = ((CNguoiQuen)cbbNguoiQuen.SelectedItem).MaGiaoDich;

            string query = @"DELETE GiaoDichTaiChinh WHERE ma_giao_dich = '"+ ma_giao_dich + "'";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi gì đó xảy ra, giao dịch không hoàn chỉnh!, EX:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DB.conn.Close();
            }
        } 
    }
}
