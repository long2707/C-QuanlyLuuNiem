using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap diem 1");
            Console.Write("nhap toa diem x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap toa diem y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Diem d1 = new Diem(x1, y1);
            d1.inDiem();
            Console.WriteLine("\nnhap diem 2");
            Console.Write("nhap toa diem x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap toa diem y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Diem d2 = new Diem(x2, y2);
            d2.inDiem();
            Diem kcc = new Diem();
            Console.Write("\nkhoang cach 2 diem: {0}", kcc.KhoangCach(d1, d2));
             kcc.KhoangCach(d1, d2);
            Console.ReadKey();
        }
    }
}
