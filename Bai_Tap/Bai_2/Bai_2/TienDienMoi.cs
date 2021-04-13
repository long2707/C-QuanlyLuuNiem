using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2
{
    class TienDienMoi:TienDien
    {
        private int dinhMuc;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhap dinh muc: ");
            dinhMuc = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("dinh muc : {0}", dinhMuc);
        }
        public override int Tinh()
        {
            if (tienDien <= dinhMuc)
            {
                return base.Tinh();
            }
            else return ((tienDien - dinhMuc) * 600 + dinhMuc * 500);
        }
    }
}
