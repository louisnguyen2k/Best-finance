using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CLoaiGiaoDich
    {
        private string _maLoaiGiaoDich;
        private string _tenLoaiGiaoDich;
        private string _maNhomGiaoDich;
        private string _img;

        public CLoaiGiaoDich(string maLoaiGiaoDich, string tenLoaiGiaoDich, string maNhomGiaoDich, string img)
        {
            _maLoaiGiaoDich = maLoaiGiaoDich;
            _tenLoaiGiaoDich = tenLoaiGiaoDich;
            _maNhomGiaoDich = maNhomGiaoDich;
            _img = img;
        }

        public string MaLoaiGiaoDich { get => _maLoaiGiaoDich; set => _maLoaiGiaoDich = value; }
        public string TenLoaiGiaoDich { get => _tenLoaiGiaoDich; set => _tenLoaiGiaoDich = value; }
        public string MaNhomGiaoDich { get => _maNhomGiaoDich; set => _maNhomGiaoDich = value; }
        public string Img { get => _img; set => _img = value; }
    }
}
