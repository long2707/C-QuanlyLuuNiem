using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang3._5
{
    class HangKho: Hang
    {
        string moTa;
         string MaHang;
          string TenHang;
        public HangKho()
        {
            moTa = "";
        }
        public HangKho(string k, string m, string h)
        {
            this.moTa = k;
            this.MaHang = m;
            this.TenHang = h;
        }
        public override void NhapHang()
        {
           
            base.NhapHang();
            Console.Write("Nhap ma ta:  ");
            moTa = Console.ReadLine();
        }
        public override void xuatHang()
        {
            base.xuatHang();
            Console.Write("\nMa ta: {0}", moTa);
        }

    }
}






