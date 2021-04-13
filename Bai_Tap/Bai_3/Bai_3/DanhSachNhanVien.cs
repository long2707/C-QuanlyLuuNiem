using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class DanhSachNhanVien
    {
        private NhanVien[] a;
        public int n;

        public void nhapds()
        {
            Console.Write("nhap so nhan vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("ban muon nhap loai nhan vien nao \n 1- nhan vien san xuat\n 2-nhan vien cong nhat\n lua chon: ");
                int loainv = int.Parse(Console.ReadLine());
                if (loainv == 1)
                {
                    a[i] = new NhanVienSanXuat();
                    a[i].Nhap();
                }
            }
        }
        NhanVienSanXuat nvsx = new NhanVienSanXuat();
        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                a[i].Xuat();
                a[i].Luong();
               
            }
        }
    }
}
