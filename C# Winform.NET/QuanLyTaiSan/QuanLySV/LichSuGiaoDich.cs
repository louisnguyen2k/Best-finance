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
    public partial class LichSuGiaoDich : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @IdUser: ID ví cần query
        // @listWallets: List object CBaseGiaoDich
        // @listItem: List control TranHistory
        public string IdUser;
        public string IDWallets;

        public string timeStart;
        public string timeEnd;

        List<CBaseGiaoDich> listTranHistory;
        UserControlTranHistory[] listItem;
        public LichSuGiaoDich(string idUser, string idWallet, string start, string end)
        {
            InitializeComponent();
            IdUser = idUser;
            IDWallets = idWallet;
            timeStart = start;
            timeEnd = end;
        }

        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            getData();
        }


        public void getData()
        {
            listTranHistory = new List<CBaseGiaoDich>();
            getDataGDTaiChinh();
            getDataGDTaiSan();

            if (listTranHistory.Count != 0)
            {
                panelLaughFace.Hide();
                sortList();
                addItem();
            }
        }
        void getDataGDTaiChinh()
        {
            string query = @"SELECT ma_giao_dich, ma_loai_gd, GiaoDichTaiChinh.ma_vi, GiaoDichTaiChinh.so_tien, thoi_gian, ghi_chu, ma_nguoi_quen 
                                FROM GiaoDichTaiChinh, VI
                                WHERE GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND taikhoan = '"+ IdUser +"'";
            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '" + IDWallets + "'";
            }
            if (checkDate() == 1)
            {
                query += "AND thoi_gian = '" + timeStart + "'";
            }
            else if (checkDate() == 2)
            {
                query += "AND (thoi_gian >= '" + timeStart + "' AND thoi_gian <= '" + timeEnd + "')";
            }
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CBaseGiaoDich gd = new CGiaoDichTaiChinh(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString());
                listTranHistory.Add(gd);
            }
            DB.conn.Close();
        }
        void getDataGDTaiSan()
        {
            string query = @"SELECT ma_giao_dich, ma_loai_gd, GiaoDichTaiSan.ma_vi, ma_tai_san, so_luong, thoi_gian, ghi_chu
                                FROM GiaoDichTaiSan, VI
                                WHERE GiaoDichTaiSan.ma_vi = VI.ma_vi
                                AND taikhoan = '" + IdUser + "'";
            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '" + IDWallets + "'";
            }
            if(checkDate() == 1)
            {
                query += "AND thoi_gian = '"+ timeStart +"'";
            }
            else if(checkDate() == 2)
            {
                query += "AND (thoi_gian >= '" + timeStart + "' AND thoi_gian <= '" + timeEnd + "')";
            }
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CBaseGiaoDich gd = new CGiaoDichTaiSan(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString());
                listTranHistory.Add(gd);
                
            }
            DB.conn.Close();
        }
        void addItem()
        {
            flowLayoutPanel.Controls.Clear();
            listItem = new UserControlTranHistory[listTranHistory.Count];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new UserControlTranHistory(this);

                listItem[i].Id = listTranHistory[i].Id;
                listItem[i].Name = getNameGD(listTranHistory[i].IdLoaiGiaoDich);
                listItem[i].Time = listTranHistory[i].getDateTime().ToString("dd-MM-yyyy");

                if (listTranHistory[i] is CGiaoDichTaiChinh) // lấy tên người quen + số tiền
                {
                    listItem[i].With = getTenNguoiQuen(((CGiaoDichTaiChinh)listTranHistory[i]).IdNguoiQuen);

                    listItem[i].Money = ((CGiaoDichTaiChinh)listTranHistory[i]).SoTien;
                    listItem[i].Type = 0;
                }
                else if (listTranHistory[i] is CGiaoDichTaiSan) // lấy tên tài sản + (số lương * giá trị)
                {
                    listItem[i].With = getTenTaiSan(((CGiaoDichTaiSan)listTranHistory[i]).IdTaiSan);

                    string soluong = ((CGiaoDichTaiSan)listTranHistory[i]).SoLuong;
                    
                    string trigia = getMoneyTaiSan(((CGiaoDichTaiSan)listTranHistory[i]).IdTaiSan);

                    float isoluong = float.Parse(soluong);
                    float ftrigia = float.Parse(trigia);
                    float result = isoluong * ftrigia;
                    
                    listItem[i].Money = result.ToString();

                    listItem[i].Type = 1;
                }

                listItem[i].Description = listTranHistory[i].MoTa;

                listItem[i].Img = getImgLoaiGiaoDich(listTranHistory[i].IdLoaiGiaoDich);
                listItem[i].MoneyColor = getThuChiGiaoDich(listTranHistory[i].IdLoaiGiaoDich).ToString();


                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel.Controls.Add(listItem[i]);
                }
            }
        }
        string getNameGD(string id)
        {
            string query = @"SELECT ten_loai_gd FROM LoaiGiaoDich
                WHERE ma_loai_gd = "+ id +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        string getTenNguoiQuen(string id)
        {
            string query = @"SELECT ten_nguoi_quen FROM NguoiQuen
                                WHERE ma_nguoi_quen = "+ id +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }
        string getTenTaiSan(string id)
        {
            string query = @"SELECT ten_tai_san FROM TaiSan
                                WHERE ma_tai_san = "+id+"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        string getImgLoaiGiaoDich(string id)
        {
            string query = @"SELECT img FROM LoaiGiaoDich
                                WHERE ma_loai_gd = "+ id +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        string getMoneyTaiSan(string id)
        {
            string query = @"SELECT tri_gia FROM TaiSan
                                    WHERE ma_tai_san = "+ id +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        int getThuChiGiaoDich(string id) // thêm tiền vào ví: 0 / mất tiền khỏi ví: 1 / error: -1
        {
            string query = @"SELECT ten_nhom_gd FROM NhomGiaoDich, LoaiGiaoDich
                                WHERE NhomGiaoDich.ma_nhom_gd = LoaiGiaoDich.ma_nhom_gd
                                AND ma_loai_gd = "+ id +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();

            if (result == "Khoản thu")
            {
                return 0;
            }
            else if (result == "Khoản chi")
            {
                return 1;
            }
            else if (result == "Đi vay/Cho vay")
            {
                string ten_giao_dich = getNameGD(id);
                if (ten_giao_dich == "Cho vay" || ten_giao_dich == "Trả nợ")
                {
                    return 1;
                }
                else if (ten_giao_dich == "Đi vay" || ten_giao_dich == "Thu nợ")
                {
                    return 0;
                }
                else
                    return -1;
            }
            else if (result == "Mua/Bán tài sản")
            {
                string ten_giao_dich = getNameGD(id);
                if (ten_giao_dich == "Mua")
                {
                    return 1;
                }
                else if (ten_giao_dich == "Bán")
                {
                    return 0;
                }
                else
                    return -1;
            }
            else
                return -1;


        }
        void sortList()
        {
            listTranHistory.Sort((gd1, gd2) => DateTime.Compare(gd2.getDateTime(), gd1.getDateTime()));
        }
        int checkDate()
        {
            if (timeStart == string.Empty && timeEnd == string.Empty)
                return 0;
            else if (timeStart != string.Empty && timeEnd == string.Empty)
                return 1;
            else
                return 2;
        }
    }
}
