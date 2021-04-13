using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class NhanVienSanXuat:NhanVien
    {
        public int soSp;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhap sop sp: " );
            soSp = Convert.ToInt32(Console.ReadLine());

        }
        public override void Xuat()
        {
            Console.WriteLine("So san pham: {0}" , soSp);
            base.Xuat();
        }
        public override void Luong()
        {
            luong = soSp * 30000;
            base.Luong();
        }
    }
}
