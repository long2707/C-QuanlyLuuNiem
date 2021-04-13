using System;

namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            nguoi ng = new nguoi();
            Console.WriteLine("no: ");
            ng.HoTen = Console.ReadLine();
            ng.ngaySinh = Convert.ToDateTime("12 / 3 / 2001");
            ng.xuat();

            themDu t = new themDu();
            Console.WriteLine("no: ");
            t.HoTen = Console.ReadLine();
            t.ngaySinh = new DateTime(27 / 3 / 2001);
            Console.Write("xuat: ");
            t.msv = Console.ReadLine();
            t.xuat();
            t.xuats();
        }
    }
}
