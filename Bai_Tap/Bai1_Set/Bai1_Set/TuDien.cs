using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_Set
{
    class TuDien : TamGiac
    {
        public double chieuCao;
        public TuDien()
        {
            chieuCao = 0;
        }
        public void nhapS()
        {
            Console.Write("nhap chieu cao: ");
            chieuCao = Convert.ToSingle(Console.ReadLine());
        }
        public void xuatS()
        {
            Console.Write("Chieu cao : {0}", chieuCao);
        }
        public void TheTich()
        {
            float V = (float)1 / 3 * (float)chieuCao * DienTich();

            Console.WriteLine("the tich tu dien: {0}", V);
        }
    }
}
