using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CNguoiQuen
    {
        private string _maNguoiQuen;
        private string _tenNguoiQuen;
        private string _sdt;
        private string _diaChi;
        private string _soTien;
        private string _maGiaoDich;
        public CNguoiQuen(string maNguoiQuen, string tenNguoiQuen, string sdt, string diaChi, string soTien)
        {
            _maNguoiQuen = maNguoiQuen;
            _tenNguoiQuen = tenNguoiQuen;
            _sdt = sdt;
            _diaChi = diaChi;
            _soTien = soTien;
        }

        public CNguoiQuen(string maNguoiQuen, string tenNguoiQuen, string sdt, string diaChi, string soTien, string maGiaoDich)
        {
            _maNguoiQuen = maNguoiQuen;
            _tenNguoiQuen = tenNguoiQuen;
            _sdt = sdt;
            _diaChi = diaChi;
            _soTien = soTien;
            _maGiaoDich = maGiaoDich;
        }

        public string MaNguoiQuen { get => _maNguoiQuen; set => _maNguoiQuen = value; }
        public string TenNguoiQuen { get => _tenNguoiQuen; set => _tenNguoiQuen = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SoTien { get => _soTien; set => _soTien = value; }
        public string MaGiaoDich { get => _maGiaoDich; set => _maGiaoDich = value; }


        private string _tenTien;
        public string TenTien
        {
            get { return _tenNguoiQuen + " " + Commom.getMoneyStr(SoTien); }
        }

        
    }
}
