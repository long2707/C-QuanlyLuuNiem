using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Diem
    {
        private Double x;
        private Double y;
        public Diem()
        {
            x = 0;
            y = 0;

        }
        public Diem(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        //public void nhap()
        //{
        //    Console.Write("nhap toa diem x: ");
        //    double x1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("nhap toa diem y: ");
        //    double y1 = Convert.ToDouble(Console.ReadLine());


        //}
        public void inDiem()
        {
            Console.Write("toa do diem 2: ({0}, {1})", x, y);
        }
        public Double KhoangCach( Diem a, Diem b)
        {
           double kc = ( Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2)));

            return kc;
        }

            
    }
}
