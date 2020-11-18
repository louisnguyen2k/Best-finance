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
    public partial class UserControlOwe : UserControl
    {
        public UserControlOwe()
        {
            InitializeComponent();
        }



        // @_id: id của ví
        // @_img: icon ảnh định dạng của ví
        // @_nameWallet: tên ví
        // @_moneyWallet: số tiền trong ví
        private string _name;
        private string _loaiNhanTra;
        private string _soLanGiaoDich;
        private string _soTien;

        [Category("Custom props")]
        public string NameP
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }

        [Category("Custom props")]
        public string LoaiNhanTra
        {
            get { return _loaiNhanTra; }
            set { _loaiNhanTra = value; lbLoaiNhanTra.Text = value; }
        }

        [Category("Custom props")]
        public string SoLanGiaoDich
        {
            get { return _soLanGiaoDich; }
            set { _soLanGiaoDich = value; lbSoGiaoDich.Text = value + " giao dịch"; }
        }

        [Category("Custom props")]
        public string SoTien
        {
            get { return _soTien; }
            set { _soTien = value; lbSoTien.Text = Commom.getMoneyStr(value); }
        }

        private void UserControlOwe_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlOwe_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
