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
    public partial class ThemVi : Form
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        // @IconListImg: list chứa đối tượng icon
        // @IconListTCurrencyUnit: list chứa đối tượng icon
        private string IDUser;
        private Vi root;
        List<CIcon> IconListImg;
        List<CIcon> IconListTCurrencyUnit;
        public ThemVi(string id, Vi father)
        {
            InitializeComponent();
            IDUser = id;
            root = father;
        }

        
        private void ThemVi_Load(object sender, EventArgs e)
        {
            addComboboxImage();
            addComboboxTienTe();

            cbbImg.SelectedIndex = 0;
            cbbImg.DisplayMember = "Name";
            cbbImg.ValueMember = "Format";

            cbbDonViTienTe.SelectedIndex = 0;
            cbbDonViTienTe.DisplayMember = "Name";
            cbbDonViTienTe.ValueMember = "Format";
        }


        private void llbThemVi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ten_vi = tbName.Text;
            string don_vi = ((CIcon)cbbDonViTienTe.SelectedItem).Name;
            string so_tien = tbSoTien.Text;
            string img = ((CIcon)cbbImg.SelectedItem).Format;

            if(ten_vi == string.Empty || so_tien == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO VI(ten_vi, don_vi, so_tien, img, taikhoan)
                            VALUES(N'"+ ten_vi + "', N'"+ don_vi + "', "+ so_tien + " , '"+ img + "', '"+ IDUser +"')";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm ví thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                root.showVi();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ví thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.showVi();
            this.Close();
        }

        private void cbbImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            getImageWallet();
        }

        private void cbbDonViTienTe_SelectedIndexChanged(object sender, EventArgs e)
        {
            getImageCurrencyUnit();
        }


        void addComboboxImage()
        {
            IconListImg = new List<CIcon>();
            CIcon i;
            i = new CIcon("Wallet", "wallet.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Bill", "bill.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Borrow", "borrow.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Buy", "buy.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Car", "car.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Credit Card", "credit-card.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Debt Collection", "debt-collection.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Box Different", "different.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Donate", "donate.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Education", "education.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Entertainment", "entertainment.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Family", "family.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Food", "food.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Gift Money", "gift-money.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Health", "health.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Credit Card", "icons-credit-card.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Interest", "interest.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Investing Business", "investing-business.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("loan", "loan.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Love & Friendship", "love-and-friendship.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Moto Cycle", "moto-cycle.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Pay", "pay.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Reward", "reward.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Salary", "salary.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Sell", "sell.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Shopping", "shopping.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Travel", "travel.PNG");
            cbbImg.Items.Add(i);

            i = new CIcon("Volleyball", "volleyball.PNG");
            cbbImg.Items.Add(i);
        }
        void addComboboxTienTe()
        {
            IconListTCurrencyUnit = new List<CIcon>();
            CIcon i;
            i = new CIcon("VND", "vnd.PNG");
            cbbDonViTienTe.Items.Add(i);
            i = new CIcon("$", "usd.PNG");
            cbbDonViTienTe.Items.Add(i);
        }
        void getImageWallet()
        {
            pbImg.Image = Image.FromFile("../../icon/" + ((CIcon)cbbImg.SelectedItem).Format );
        }
        void getImageCurrencyUnit()
        {
            pbDonViTienTe.Image = Image.FromFile("../../icon/" + ((CIcon)cbbDonViTienTe.SelectedItem).Format );
            pbSoTien.Image = Image.FromFile("../../icon/" + ((CIcon)cbbDonViTienTe.SelectedItem).Format );
        }

        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
