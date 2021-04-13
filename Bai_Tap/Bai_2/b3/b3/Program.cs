using System;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Nhap so phan tu mang: ");
            m = Convert.ToInt32(Console.ReadLine());
            Mang1Chieu mang = new Mang1Chieu(m);
            mang.nhapMang(m);
            mang.inMang(m);
            int thutu1;
            Console.Write("nhap thu tu: ");
            thutu1 = Convert.ToInt32(Console.ReadLine());
            mang.sapXep(thutu1);
            mang.inMang(m);
            mang.TimKiem(m);
            Console.ReadKey();

        }
    }
}
