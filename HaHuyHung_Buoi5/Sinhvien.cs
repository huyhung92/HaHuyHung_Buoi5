using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaHuyHung_Buoi5
{
    public class Sinhvien:Nguoi
    {
        private string MSSV;
        private string Nganhhoc;
        private double ĐTB;

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string Nganhhoc1 { get => Nganhhoc; set => Nganhhoc = value; }
        public double ĐTB1 { get => ĐTB; set => ĐTB = value; }

        public Sinhvien() : base()
        {

        }

        public Sinhvien(string Hoten, string Gioitinh, DateTime Ngaysinh, string MSSV, string Nganhhoc, double ĐTB) :base ()
        {
           this.Hoten1 = Hoten;
           this.Gioitinh1 = Gioitinh;
           this.Ngaysinh1 = Ngaysinh;
           this.MSSV = MSSV;
           this.Nganhhoc = Nganhhoc;
           this.ĐTB = ĐTB;
        }
    }
}
