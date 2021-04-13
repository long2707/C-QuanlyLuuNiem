using System;
using System.Collections.Generic;
using System.Text;

namespace bài6
{
    class DanhSach
    {
        private sinhVien[] slsv;
        private int n;
        public void nhapds()
        {
            Console.Write("nhap so luong sinh vien: ");
             n = Convert.ToInt32(Console.ReadLine());
            slsv = new sinhVien[n];
            for (int i = 0; i < n; i++)
            {
                slsv[i] = new sinhVien();
                slsv[i].Nhap();

            }
        }
        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                slsv[i].xuat();
            }
        }
    }
}
