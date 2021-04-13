using System;

namespace c3
{
    class Program
    {
        static void Main(string[] args)
        {
            hcn h1 = new hcn();
            h1.nhap();
            h1.chuvi();
            Console.WriteLine("dien tich hcn :{0}", h1.dt());
            hcn h4 = new hcn(h1);
            Console.WriteLine("dien tich :{0}", h4.dt());
        }
    }
}
