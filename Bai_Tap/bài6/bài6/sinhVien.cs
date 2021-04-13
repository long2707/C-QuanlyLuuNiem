using System;
using System.Collections.Generic;
using System.Text;

namespace bài6
{
    class sinhVien
    {
        private string msv, HoTen, QueQuan;
        private int namSinh;
        private float Dlt, DiemCSDL, DiemTb;

        public sinhVien()
        {

        }

         public void Nhap()
        {
            Console.Write("nhap msv: ");
            msv = Console.ReadLine();
            Console.Write("nhap ten sv: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("nhap nam sinh: ");
            namSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem : ");
            DiemCSDL = Convert.ToSingle(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write(" " + msv + " " + HoTen + " " + QueQuan + " " + namSinh + "" + DiemCSDL);
        }
        public string Hoten
        {
            get
            {
                return HoTen;
            }
            set
            {
                HoTen = value;

            }
        }
        public int NSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
    }
}
