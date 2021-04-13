using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong2_
{
    class SinhVien
    {
        string[] hoTen = new string[20];
        string[] msv = new string[15];
        public void nhap()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("nhap ma sinh vien {0}", i);
                msv [i] = Console.ReadLine();
                Console.WriteLine("nhap ten sinh vien {0}", i);
                hoTen[i] = Console.ReadLine();
            }
        }
        public void xuat()
        {
            for (int i = 1; i <=5 ; i++)
            {
                Console.WriteLine("thong tin sinh vien {0}", i);
                Console.WriteLine("msv: {0}", msv[i]);
                Console.WriteLine("hoTen: {0}", hoTen[i]);

            }
        }
    }
}
