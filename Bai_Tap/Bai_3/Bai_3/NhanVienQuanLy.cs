using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class NhanVienQuanLy:NhanVien
    {
        public int HsL;
        public int Lcb;
        public void NhapQL()
        {
            Console.Write("nhap he so luong: ");
            HsL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            Lcb = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("he so luong: {0}", HsL);
            Console.WriteLine("luong co ban: {0}", Lcb);
        }
        public override void Luong()
        {
            luong = HsL * Lcb;
            base.Luong();
        }
    }
}
