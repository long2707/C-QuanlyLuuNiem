using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang3._5
{
    class Hang
    {
         string Mahang;
         string TenHang;

        public Hang()
        {
            Mahang = "";
            TenHang = "";
        }
        public  Hang(string ma, string ten)
        {
            this.Mahang = ma;
            this.TenHang = ten;
        }
        public virtual void NhapHang()
        {
            Console.Write("Nhap ma hang: ");
            Mahang = Console.ReadLine();
            Console.Write("Nhap Ten  hang: ");
            TenHang = Console.ReadLine();
        }
        public virtual void xuatHang()
        {
            Console.Write("Ma hang : {0}", Mahang);
            Console.Write("\nTen hang: {0}", TenHang);
        }
    }
}
