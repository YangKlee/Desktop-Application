using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BTH4_B4
{
    internal class SinhVien
    {
        public string maSinhVien;
        public string hoTen;
        public string DiaChi;
        public DateTime ngaySinh;
        public string lop;
        public SinhVien()
        {
            
        }
        public SinhVien(string msv, string hoten, string diachi, DateTime birth, string lop)
        {
            this.hoTen = hoten;
            this.maSinhVien = msv;
            this.DiaChi = diachi;
            this.ngaySinh = birth;
            this.lop = lop;
        }
    }
}
