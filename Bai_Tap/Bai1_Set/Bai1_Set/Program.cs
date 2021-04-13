using System;

namespace Bai1_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tg = new TamGiac();
            tg.Nhap();
            tg.Xuat();

            Console.WriteLine("dien tich tam giac: {0}", tg.DienTich());
            TuDien td = new TuDien();
            td.Nhap();
            td.nhapS();
            td.Xuat();
            td.xuatS();
            td.TheTich();
            Console.Read();

        }
    }
}
