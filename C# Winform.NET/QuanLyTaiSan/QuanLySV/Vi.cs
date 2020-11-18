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
    public partial class Vi : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        // @listWallets: List object Wallets
        // @listItem: List control wallets
        public string IDUser;
        public TaiKhoan root;
        List<CWallet> listWallets;
        UserControlWallets[] listItem;


        public Vi(string id, TaiKhoan tk)
        {
            InitializeComponent();
            root = tk;
            IDUser = id;
        }

        private void Vi_Load(object sender, EventArgs e)
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
            ThemVi fr = new ThemVi(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm2(fr);
        }


        /* Lấy dữ liệu từ DB đổ lên List */
        void getData()
        {
            listWallets = new List<CWallet>();

            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CWallet wl = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                listWallets.Add(wl);
            }
            DB.conn.Close();

            addItem();
        }

        /* Add các ví lên flowLayoutPanel */
        void addItem()
        {
            flowLayoutPanel.Controls.Clear();
            listItem = new UserControlWallets[listWallets.Count];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new UserControlWallets(IDUser, this);
                listItem[i].Id = listWallets[i].Id;
                listItem[i].Img = listWallets[i].getImage();
                listItem[i].NameWallet = listWallets[i].getName();
                listItem[i].MoneyWallet = listWallets[i].Money;
                listItem[i].Type = listWallets[i].Type;

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

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
