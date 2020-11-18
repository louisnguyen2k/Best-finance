using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CIcon
    {
        private string _name;
        private string _format;

        public CIcon(string name, string format)
        {
            _name = name;
            _format = format;
        }

        public string Name { get => _name; set => _name = value; }
        public string Format { get => _format; set => _format = value; }
    }
}
