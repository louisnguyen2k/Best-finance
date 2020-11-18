using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CSoNo
    {
        private string _ten;
        private string _loaiNhanTra;
        private string _soTien;
        private string _soLanGiaoDich;
        

        public CSoNo(string ten, string loaiNhanTra, string soTien, string soLanGiaoDich)
        {
            _ten = ten;
            _loaiNhanTra = loaiNhanTra;
            _soTien = soTien;
            _soLanGiaoDich = soLanGiaoDich;
        }

        public string Ten { get => _ten; set => _ten = value; }
        public string LoaiNhanTra { get => _loaiNhanTra; set => _loaiNhanTra = value; }
        public string SoTien { get => _soTien; set => _soTien = value; }
        public string SoLanGiaoDich { get => _soLanGiaoDich; set => _soLanGiaoDich = value; }
    }
}
