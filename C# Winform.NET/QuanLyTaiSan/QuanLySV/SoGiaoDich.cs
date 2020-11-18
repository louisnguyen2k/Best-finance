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
    public partial class SoGiaoDich : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @dictWallets: Dictionary object Wallets
        public string IDUser;
        List<CWallet> listWallets;


        public SoGiaoDich(string id)
        {
            InitializeComponent();
            IDUser = id;
        }

        private void SoGiaoDich_Load(object sender, EventArgs e)
        {
            getDataVi();
            cbbVi.ValueMember = "Id";
            cbbVi.DisplayMember = "Name";
            getDataVi();
            try
            {
                cbbVi.SelectedIndex = 0;
                getImageViTien();
            }
            catch (Exception) { }
        }
        private void cbbVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVi.SelectedIndex == -1) return;
            getImageViTien();
            getLbGiaoDichDauCuoi(((CWallet)cbbVi.SelectedItem).Id);

            loadForm();

        }

        void loadForm()
        {
            panelLoad.Controls.Clear();
            string idWallet = ((CWallet)cbbVi.SelectedItem).Id;
            ChiTietSoGiaoDich fr = new ChiTietSoGiaoDich(IDUser, idWallet) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }




        void getDataVi()
        {

            cbbVi.Items.Clear();

            listWallets = new List<CWallet>();

            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CWallet wl = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                //
                listWallets.Add(wl);
            }
            DB.conn.Close();
            addWallets();
        }

        void addWallets()
        {
            double db_vn_money = 0;

            foreach (CWallet wl in listWallets)
            {
                if(wl.Type == Commom.StrDOLA)
                {
                    db_vn_money += wl.getFMoney() *Commom.VND;
                }
                else
                {
                    db_vn_money += wl.getFMoney();
                }
            }
            cbbVi.Items.Add(new CWallet("", "global.PNG", "Global", db_vn_money.ToString(), Commom.StrVND));
            foreach (CWallet wl in listWallets)
            {
                cbbVi.Items.Add(wl);
            }
        }

        void getImageViTien()
        {
            string name_img = ((CWallet)cbbVi.SelectedItem).Img;
            pbVi.Image = Commom.getImage(name_img);
            string type_money = ((CWallet)cbbVi.SelectedItem).Type;
            if (type_money == "VND")
                pbTypeMoney.Image = Commom.getImage("vnd.PNG");
            else
                pbTypeMoney.Image = Commom.getImage("usd.PNG");

            lbNameWallet.Text = ((CWallet)cbbVi.SelectedItem).Name;
            lbMoney.Text = Commom.getMoneyStr(((CWallet)cbbVi.SelectedItem).Money) + ((CWallet)cbbVi.SelectedItem).Type;
        }

        void getLbGiaoDichDauCuoi(string id)
        {
            double db_earn_money = 0;
            double db_pay_money = 0;

            string earn_money_query = @"SELECT dbo.GET_Earnings('"+ id +"', '"+ IDUser +"')";
            SqlCommand cmd = new SqlCommand(earn_money_query, DB.conn);
            DB.conn.Open();
            try
            {
                db_earn_money = double.Parse(cmd.ExecuteScalar().ToString());
            }
            catch(Exception){ }
            DB.conn.Close();


            string pay_money_query = @"SELECT dbo.GET_Paying('" + id + "', '" + IDUser + "')";
            cmd = new SqlCommand(pay_money_query, DB.conn);
            DB.conn.Open();
            try
            {
                db_pay_money = double.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception) { }
            DB.conn.Close();

            string money_type = ((CWallet)cbbVi.SelectedItem).Type;

            double db_wallet_money_at_end = double.Parse(((CWallet)cbbVi.SelectedItem).Money);

            double db_wallet_money_at_first = (db_wallet_money_at_end - db_earn_money) + db_pay_money;
            
            lbAtFirstMoney.Text = Commom.getMoneyStr(db_wallet_money_at_first.ToString()) + money_type;
            lbAtEndMoney.Text = Commom.getMoneyStr(db_wallet_money_at_end.ToString()) + money_type;
            double db_wallet_money_at_final = (db_wallet_money_at_end - db_wallet_money_at_first);
            
            if(db_wallet_money_at_final >= 0)
            {
                lbAtFinalMoney.Text = "+" + Commom.getMoneyStr(db_wallet_money_at_final.ToString()) + money_type;
            }
            else
            {
                lbAtFinalMoney.Text = Commom.getMoneyStr(db_wallet_money_at_final.ToString()) + money_type;
            }

        }
        
    }
}
