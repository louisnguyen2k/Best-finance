using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CNhomGiaoDich
    {
        private string _maNhom;
        private string _tenNhom;

        public CNhomGiaoDich(string maNhom, string tenNhom)
        {
            _maNhom = maNhom;
            _tenNhom = tenNhom;
        }

        public string MaNhom { get => _maNhom; set => _maNhom = value; }
        public string TenNhom { get => _tenNhom; set => _tenNhom = value; }
    }
}
