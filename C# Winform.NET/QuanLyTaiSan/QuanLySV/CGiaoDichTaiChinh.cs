using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CGiaoDichTaiChinh : CBaseGiaoDich
    {
        private string _soTien;
        private string _idNguoiQuen;
        public CGiaoDichTaiChinh(string id, string idLoaiGiaoDich, string idVi, string soTien, string thoiGian, string ghiChu, string idNguoiQuen) : base(id, idLoaiGiaoDich, idVi, thoiGian, ghiChu)
        {
            _soTien = soTien;
            _idNguoiQuen = idNguoiQuen;
        }


        public string SoTien { get => _soTien; set => _soTien = value; }
        public string IdNguoiQuen { get => _idNguoiQuen; set => _idNguoiQuen = value; }
    }
}
