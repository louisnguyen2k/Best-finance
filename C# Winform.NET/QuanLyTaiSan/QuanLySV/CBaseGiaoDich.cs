using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CBaseGiaoDich
    {
        private string _id;
        private string _idLoaiGiaoDich;
        private string _idVi;
        private string _thoiGian;
        private string _moTa;
        public CBaseGiaoDich(string id, string idLoaiGiaoDich, string idVi, string thoiGian, string moTa)
        {
            _id = id;
            _idLoaiGiaoDich = idLoaiGiaoDich;
            _idVi = idVi;
            string[] list = thoiGian.Split(' ');
            _thoiGian = list[0];
            _moTa = moTa;
        }

        public string Id { get => _id; set => _id = value; }
        public string IdLoaiGiaoDich { get => _idLoaiGiaoDich; set => _idLoaiGiaoDich = value; }
        public string IdVi { get => _idVi; set => _idVi = value; }
        public string ThoiGian { get => _thoiGian; set => _thoiGian = value; }
        public string MoTa { get => _moTa; set => _moTa = value; }

        public DateTime getDateTime()
        {
            string[] listStr = _thoiGian.Split('/');
            int d = Convert.ToInt32(listStr[0]);
            int m = Convert.ToInt32(listStr[1]);
            int y = Convert.ToInt32(listStr[2]);
            return new DateTime(y, d, m);
        }
    }
}
