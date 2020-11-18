using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CGiaoDichTaiSan : CBaseGiaoDich
    {
        private string _idTaiSan;
        private string _soLuong;
        public CGiaoDichTaiSan(string id, string idLoaiGiaoDich, string idVi, string idTaiSan, string soLuong, string thoiGian, string ghiChu) : base(id, idLoaiGiaoDich, idVi, thoiGian, ghiChu)
        {
            _idTaiSan = idTaiSan;
            _soLuong = soLuong;
        }

        public string IdTaiSan { get => _idTaiSan; set => _idTaiSan = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
