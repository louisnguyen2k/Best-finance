using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class UserControlWallets : UserControl
    {

        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại(Vi)
        public string IDUser;
        public Vi root;


        // @_id: id của ví
        // @_img: icon ảnh định dạng của ví
        // @_nameWallet: tên ví
        // @_moneyWallet: số tiền trong ví
        private string _id;
        private Image _img;
        private string _nameWallet;
        private string _moneyWallet;
        private string _type;


        public UserControlWallets(string id, Vi father)
        {
            InitializeComponent();
            IDUser = id;
            root = father;
        }








        [Category("Custom props")]
        public string Id
        {
            get { return _id; }
            set { _id = value;}
        }


        [Category("Custom props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; rpbImg.Image = value; }
        }


        [Category("Custom props")]
        public string NameWallet
        {
            get { return _nameWallet; }
            set { _nameWallet = value; labelName.Text = value; }
        }


        [Category("Custom props")]
        public string MoneyWallet
        {
            get { return _moneyWallet; }
            set { _moneyWallet = value; labelMoney.Text = getMoneyStr(value); }
        }


        [Category("Custom props")]
        public string Type
        {
            get { return _type; }
            set { _type = value; labelMoney.Text = labelMoney.Text + " " + value; }
        }


        public string getMoneyStr(string Money)
        {
            float fmoney = float.Parse(Money);

            decimal decimal_value = Math.Round(Convert.ToDecimal(fmoney), 2);

            string[] listStr = decimal_value.ToString().Split('.');

            char[] listChar = listStr[0].ToCharArray(); // 1 - 2

            string result = "";
            int count = 0;
            for (int i = listChar.Length - 1; i >= 0; i--)
            {
                if (count % 3 == 0 && count != 0)
                {
                    result += "," + listChar[i];
                }
                else
                {
                    result += listChar[i];
                }
                count++;
            }



            if (listStr.Length == 1)
            {
                return Reverse(result) + " ";
            }
            else
            {
                return Reverse(result) + "." + listStr[1] + " ";
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }





        private void UserControlWallets_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlWallets_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlWallets_Click(object sender, EventArgs e)
        {
            ChiTietVi fr = new ChiTietVi(IDUser, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            root.LoadForm2(fr);
            //ChiTietVi fr = new ChiTietVi(IDUser, this);
            //fr.ShowDialog();
            //fr.Close();
        }
    }
}
