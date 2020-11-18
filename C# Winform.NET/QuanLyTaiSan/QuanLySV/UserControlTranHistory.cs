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
    public partial class UserControlTranHistory : UserControl
    {

        private LichSuGiaoDich root;

        public UserControlTranHistory(LichSuGiaoDich father)
        {
            InitializeComponent();
            root = father;
        }

        

        private string _id;
        private string _name;
        private string _time;
        private string _with; // -- tài sản - người quen --
        private string _description;
        private string _img;
        private string _money;

        private string _moneyColor; // màu chữ của tiền
        private int _type; // đối tượng này là gì? 0: tài chính, 1: tài sản







        [Category("Custom props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; lbName.Text = value; }
        }

        [Category("Custom props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; lbTime.Text = value; }
        }

        [Category("Custom props")]
        public string With
        {
            get { return _with; }
            set { _with = value; }
        }

        [Category("Custom props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbDescription.Text = value + " (" + _with + ")"; }
        }

        [Category("Custom props")]
        public string Img
        {
            get { return _img; }
            set { _img = value; rpbImg.Image = Commom.getImage(value); }
        }

        [Category("Custom props")]
        public string Money
        {
            get { return _money; }
            set { _money = value; lbMoney.Text = Commom.getMoneyStr(value); }
        }


        [Category("Custom props")]
        public string MoneyColor
        {
            get { return _moneyColor; }
            set { _moneyColor = value; lbMoney.ForeColor = value == "0" ? Color.ForestGreen : Color.Red; }
        }

        [Category("Custom props")]
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }




        private void UserControlTranHistory_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlTranHistory_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlTranHistory_Click(object sender, EventArgs e)
        {
            ChiTietGiaoDich ct = new ChiTietGiaoDich(Id, Type, MoneyColor);
            ct.ShowDialog();
            ct.Close();
            root.getData();
        }

    }
}
