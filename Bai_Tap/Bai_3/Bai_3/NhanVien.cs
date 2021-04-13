using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class NhanVien
    {
        public string HoTen;
        public string DiaChi;
        public DateTime NgaySinh;
        public float luong;
      

        public virtual void Nhap()
        {
            Console.Write("nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap dia chi nhan vien: ");
            DiaChi = Console.ReadLine();
            Console.Write("nhap ngay sinh nhan vien: ");
            NgaySinh = Convert.ToDateTime(Console.ReadLine());
           
        }
        public virtual void Xuat()
        {
            Console.WriteLine("ho ten nhan vien: {0}", HoTen);
            Console.WriteLine("nhap dia chi: {0}", DiaChi);
            Console.WriteLine("nhap ngay sinh: {0}/{1}/{2}", NgaySinh.Day, NgaySinh.Month, NgaySinh.Year);
           
        }
        public virtual void Luong()
        {
            Console.WriteLine("Luong cua nhan vien: {0}", luong);

        }
    }
}
