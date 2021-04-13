using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_Set
{
    class TamGiac
    {
        public Double canh1;
        public double canh2;
        public double  canh3;

        public TamGiac()
        {
            canh1 = 0;
            canh2 = 0;
            canh3 = 0;
        }
        public void Nhap()
        {
            Console.Write("nhap canh thu 1: ");
            canh1 = double.Parse(Console.ReadLine());
            Console.Write("nhap canh thu 2: ");
            canh2 = double.Parse(Console.ReadLine());
            Console.Write("nhap canh thu 3: ");
            canh3 = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("canh thu 1: {0}", canh1);
            Console.Write("canh thu 2: {0}\n", canh2);
            Console.Write("canh thu 3: {0}\n", canh3);
        }
        public float DienTich()
        {
            float cv = (float)((canh1 + canh2 + canh3) * (canh1 + canh2 - canh3) * (canh1 - canh2 + canh3) * (canh3 + canh2 - canh1));

            float s = (float)(0.25 * Math.Sqrt(cv));

            return s;
        }
    }
}
