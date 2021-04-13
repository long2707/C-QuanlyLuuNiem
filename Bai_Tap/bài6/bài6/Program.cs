using System;

namespace bài6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            sinhVien sv = new sinhVien();
            Console.WriteLine("NHAP ten: ");
            sv.Hoten = Console.ReadLine();
            Console.WriteLine(""+sv.Hoten );
        }
    }
}
