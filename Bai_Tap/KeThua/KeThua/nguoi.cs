using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua
{
    class nguoi
    {
        public string HoTen;
        public DateTime ngaySinh;

        public void xuat()
        {
            Console.WriteLine("{0}", HoTen);
            Console.WriteLine("{0}/{1}/{2}", ngaySinh.Day, ngaySinh.Month, ngaySinh.Year);
        }
    }
}
