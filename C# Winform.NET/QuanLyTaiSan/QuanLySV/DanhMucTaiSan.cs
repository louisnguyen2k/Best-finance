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
    public partial class DanhMucTaiSan : Form
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        // @listWallets: List object Wallets
        // @listItem: List control wallets
        public string IDUser;
        public TaiKhoan root;
        List<CTaiSan> listTaiSan;
        UserControlTaiSan[] listItem;



        public DanhMucTaiSan(string id, TaiKhoan father)
        {
            InitializeComponent();
            root = father;
            IDUser = id;
        }


        private void DanhMucTaiSan_Load(object sender, EventArgs e)
        {
            getData();
        }


        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.showMenu();
            this.Close();
        }

        private void llbThemVi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemTaiSan fr = new ThemTaiSan(IDUser);
            fr.ShowDialog();
            fr.Close();
            getData();
        }



        public void getData()
        {
            listTaiSan = new List<CTaiSan>();

            string query = @"SELECT ma_tai_san, ten_tai_san, so_luong, tri_gia, mo_ta, img
                            FROM TaiSan
                            WHERE taikhoan = '"+ IDUser + "' ORDER BY so_luong * tri_gia DESC";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CTaiSan ppt = new CTaiSan(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), (byte[])rd[5]);
                listTaiSan.Add(ppt);
            }
            DB.conn.Close();
            addItem();
        }

        /* Add các ví lên flowLayoutPanel */
        void addItem()
        {
            flowLayoutPanel.Controls.Clear();
            listItem = new UserControlTaiSan[listTaiSan.Count];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new UserControlTaiSan(this);

                listItem[i].Id = listTaiSan[i].Id;
                listItem[i].Name = listTaiSan[i].Name;
                listItem[i].Value = listTaiSan[i].Value;
                listItem[i].Count = listTaiSan[i].Count;
                listItem[i].Description = listTaiSan[i].Description;
                listItem[i].Img = listTaiSan[i].getImage();

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

        /* Add form con lên panel thứ 3  ở form cha*/
        public void LoadForm2(Form fr)
        {
            root.LoadForm2(fr);
        }

        /* Hiện form hiện tại lên panel */
        public void showVi()
        {
            getData();
            root.showLoad1();
        }

        
    }
}
