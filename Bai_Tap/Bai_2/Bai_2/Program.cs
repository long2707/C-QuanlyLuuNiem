using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TienDienMoi td = new TienDienMoi();
            td.Nhap();
            td.xuat();
            Console.WriteLine("tien dien: {0}", td.Tinh());
            Console.Read();
        }
    }
}
