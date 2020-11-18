using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CWallet
    {
        private string _id;
        private string _img;
        private string _name;
        private string _money;
        private string _type;
        public CWallet(string id,string img, string name, string money, string type)
        {
            _id = id;
            _img = img;
            _name = name;
            _money = money;
            _type = type;
        }

        

        public string Id { get => _id; set => _id = value; }
        public string Img { get => _img; set => _img = value; }
        public string Name { get => _name; set => _name = value; }
        public string Money { get => _money; set => _money = value; }
        public string Type { get => _type; set => _type = value; }

        public string NameMoneyType { get => _name + " (" + Commom.getMoneyStr(_money) + " " + _type + ")"; }

        public string getName()
        {
            return Name;
        }
        public Image getImage()
        {
            Image img;
            try
            {
                img =  Image.FromFile("../../icon/" + Img);
            }
            catch (Exception)
            {
                img = null;
            }
            return img;
        }

        public float getFMoney()
        {
            return float.Parse(_money);
        }

        

    }
}
