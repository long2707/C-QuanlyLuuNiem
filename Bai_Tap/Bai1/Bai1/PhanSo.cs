using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class PhanSo
    {
        private int mauS;
        private int tuS;
        public PhanSo()
        {
            tuS = 0;
            mauS = 1;
        }
        public PhanSo(int tu, int mau)
        {
            tuS = tu;
            mauS = mau;
        }
        public void inPhanSo()
        {


            Console.WriteLine(" {0} / {1}", tuS, mauS);
        }

        public int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a!=b&&a!=0&&b!=0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }

            }
            return a;
        }
        public PhanSo rutGon(PhanSo rg)
        {
           
            int u = UCLN(tuS, mauS);
            if (u != 0)
            {
                rg.tuS = tuS/ u;
                rg.mauS = mauS/ u;
            }
            else
            {
                rg.tuS = tuS;
                rg.mauS = mauS;
            }
            return rg;
        }
        public PhanSo tong(PhanSo p1, PhanSo p2)
        {
            
            int tu = p1.tuS * p2.mauS + p2.tuS  * p1.mauS;
            int mau = p1.mauS * p2.mauS;
            PhanSo kq = new PhanSo(tu, mau);
            kq.rutGon(kq);
            return kq;
           
        }
        public PhanSo Hieu(PhanSo p1, PhanSo p2)
        {

            int tu = p1.tuS * p2.mauS - p2.tuS * p1.mauS;
            int mau = p1.mauS * p2.mauS;
            PhanSo kq = new PhanSo(tu, mau);
            kq.rutGon(kq);
            return kq;

        }
        public PhanSo tich(PhanSo p1, PhanSo p2)
        {

            int tu = p1.tuS * p2.tuS;
            int mau = p1.mauS * p2.mauS;
            PhanSo kq = new PhanSo(tu, mau);
            kq.rutGon(kq);
            return kq;

        }
        public PhanSo thuong(PhanSo p1, PhanSo p2)
        {

            int tu = p1.tuS * p2.mauS ;
            int mau = p1.mauS * p2.tuS;
            PhanSo kq = new PhanSo(tu, mau);
            kq.rutGon(kq);
            return kq;

        }

    }
}
