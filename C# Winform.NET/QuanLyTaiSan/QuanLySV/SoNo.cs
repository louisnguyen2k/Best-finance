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
    public partial class SoNo : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        // @listWallets: List object CSoNo
        // @listItem: List control Owes
        public string IDUser;
        public TaiKhoan root;
        List<CSoNo> listWallets;
        UserControlOwe[] listItem;


        public SoNo(string id, TaiKhoan father)
        {
            InitializeComponent();
            IDUser = id;
            root = father;
        }

        private void SoNo_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.showMenu();
            this.Close();
        }


        /* Lấy dữ liệu từ DB đổ lên List */
        void getData()
        {
            listWallets = new List<CSoNo>();

            float sum_cho_vay = 0, sum_di_vay = 0;

            string query = @"SELECT NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd , SUM(GiaoDichTaiChinh.so_tien) , COUNT(*)
                                FROM GiaoDichTaiChinh, TaiKhoan, VI, NguoiQuen, LoaiGiaoDich
                                WHERE TaiKhoan.taikhoan = VI.taikhoan
                                AND TaiKhoan.taikhoan = NguoiQuen.taikhoan

                                AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen

                                AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd

                                AND TaiKhoan.taikhoan = '" + IDUser +"'" +
                                "AND(LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR LoaiGiaoDich.ten_loai_gd = N'Cho vay')" +
                                "AND NguoiQuen.ma_nguoi_quen != " + Commom.clone_nguoi_quen +"" +
                                "GROUP BY NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CSoNo owe = new CSoNo(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
                listWallets.Add(owe);
                if (owe.LoaiNhanTra == "Đi vay")
                {
                    sum_di_vay += float.Parse(owe.SoTien);
                }
                else if(owe.LoaiNhanTra == "Cho vay")
                {
                    sum_cho_vay += float.Parse(owe.SoTien);
                }
            }
            DB.conn.Close();
            lbChoVay.Text = Commom.getMoneyStr(sum_cho_vay.ToString());
            lbDiVay.Text = Commom.getMoneyStr(sum_di_vay.ToString());
            addItem();
        }

        /* Add các sổ nợ lên flowLayoutPanel */
        void addItem()
        {
            flowLayoutPanel.Controls.Clear();
            listItem = new UserControlOwe[listWallets.Count];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new UserControlOwe();
                listItem[i].NameP = listWallets[i].Ten;
                listItem[i].LoaiNhanTra = listWallets[i].LoaiNhanTra;
                listItem[i].SoLanGiaoDich = listWallets[i].SoLanGiaoDich;
                listItem[i].SoTien = listWallets[i].SoTien;


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

        
    }
}
