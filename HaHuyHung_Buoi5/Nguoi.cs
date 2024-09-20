using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaHuyHung_Buoi5
{
    public class Nguoi
    {
        private string Hoten;
        private string Gioitinh;
        private DateTime Ngaysinh;

        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public DateTime Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }

        public Nguoi() { }

        public Nguoi(string hoten, string gioitinh, DateTime ngaysinh)
        {
            Hoten = hoten;
            Gioitinh = gioitinh;
            Ngaysinh = ngaysinh;            
        }
    }
}
