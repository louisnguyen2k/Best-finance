using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CTaiSan
    {
        private string _id;
        private string _name;
        private string _count;
        private string _value;
        private string _description;
        private byte[] _img;

        public CTaiSan(string id, string name, string count, string value, string description, byte[] img)
        {
            _id = id;
            _name = name;
            _count = count;
            _value = value;
            _description = description;
            _img = img;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Count { get => _count; set => _count = value; }
        public string Value { get => _value; set => _value = value; }
        public string Description { get => _description; set => _description = value; }
        public byte[] Img { get => _img; set => _img = value; }



        public Image getImage()
        {
            MemoryStream stream = new MemoryStream(_img.ToArray());
            Image image = Image.FromStream(stream);
            if (image == null)
                return null;
            return image;
        }
    }
}
