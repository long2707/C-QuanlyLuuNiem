using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap tu so phan so thu 1: ");
            int tu = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap mau so phan so thu 1: ");
            int mau = Convert.ToInt32(Console.ReadLine());
            PhanSo ps1 = new PhanSo(tu, mau);
            Console.Write("phan so thu 1: ");
            ps1.rutGon(ps1);
            ps1.inPhanSo();

            Console.Write("nhap tu so phan so thu 2: ");
            int tu2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap mau so phan so thu 2: ");
            int mau2 = Convert.ToInt32(Console.ReadLine());
            PhanSo ps2 = new PhanSo(tu2, mau2);
            Console.Write("phan so thu 2: ");
            ps2.rutGon(ps2);
            ps2.inPhanSo();

            PhanSo sum = new PhanSo();
            sum = sum.tong(ps1, ps2);
            Console.Write("tong  2 phan so: ");
            sum.inPhanSo();

            sum = sum.Hieu(ps1, ps2);
            Console.Write("hieu 2 phan so: ");
            sum.inPhanSo();

            sum = sum.tich(ps1, ps2);
            Console.Write("tich 2 phan so: ");
            sum.inPhanSo();

            sum = sum.thuong(ps1, ps2);
            Console.Write("thuong 2 phan so: ");
            sum.inPhanSo();

            Console.Read();
        }
    }
}
