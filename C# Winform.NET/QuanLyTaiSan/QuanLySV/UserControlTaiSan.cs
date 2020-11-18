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
    public partial class UserControlTaiSan : UserControl
    {
        /*PROPERTY*/
        // @root: Form cha mở form hiện tại(DanhMucTaiSan).
        public DanhMucTaiSan root;


        // @_id: id tài sản
        // @_name: tên tài sản
        // @_count: số lượng tài sản đang sở hữu
        // @_value: giá trị của một sản phẩm
        // @_description: mô tả tài sản
        // @_img: ảnh tài sản
        private string _id;
        private string _name;
        private string _count;
        private string _value;
        private string _description;
        private Image _img;



        public UserControlTaiSan(DanhMucTaiSan father)
        {
            InitializeComponent();
            root = father;
        }



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
            set { _name = value; labelName.Text = value; }
        }

        [Category("Custom props")]
        public string Value
        {
            get { return _value; }
            set { _value = value; labelValue.Text = Commom.getMoneyStr(value); getTongGiaTri(); }
        }


        [Category("Custom props")]
        public string Count
        {
            get { return _count; }
            set { _count = value; labelCount.Text = value; getTongGiaTri();}
        }


        

        [Category("Custom props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        [Category("Custom props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; pbImg.Image = value; }
        }


        void getTongGiaTri()
        {
            if(_count == string.Empty || _value == string.Empty)
            {
                return;
            }
            int iCount = Convert.ToInt32(_count);
            float fValue = float.Parse(_value);
            float tongGiaTri = iCount * fValue;
            labelTongGiaTri.Text = Commom.getMoneyStr(tongGiaTri.ToString());
        }




        private void UserControlTaiSan_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlTaiSan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlTaiSan_Click(object sender, EventArgs e)
        {
            ChiTietTaiSan fr = new ChiTietTaiSan(Id);
            fr.ShowDialog();
            fr.Close();
            root.getData();
        }
    }
}
