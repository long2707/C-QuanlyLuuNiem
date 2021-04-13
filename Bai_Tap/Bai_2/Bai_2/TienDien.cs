using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2
{
    class TienDien
    {
        public string chuHo;
        public string DiaChi;
        public int CongTotrc;
        public int CongTonay;
        public TienDien() { 
            chuHo = "";
            DiaChi = "";
            CongTotrc = 0;
            CongTonay = 0;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten chu ho: ");
            chuHo = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("nhap cong to thang truoc: ;");
            CongTotrc = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap cong to thang nay: ");
            CongTonay = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void xuat()
        {
            Console.WriteLine(" " + chuHo + " " + DiaChi + " " + CongTotrc + " " + CongTonay);

        }

        public  int tienDien
        {
            get { return CongTonay - CongTotrc; }
        }
        public virtual int Tinh()
        {
            return tienDien * 500;
        }
    }
}
