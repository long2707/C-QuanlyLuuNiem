using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class NhanVienCongNhat:NhanVien
    {
        public int soNc;
        public void nhapNvcn()
        {
            Console.Write("so ngay cong: ");
            soNc = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            
            base.Xuat();
            Console.WriteLine("so ngay cong: {0}", soNc);
        }
        public override void Luong()
        {
            luong = soNc * 90000;
            base.Luong();
        }
    }
}
