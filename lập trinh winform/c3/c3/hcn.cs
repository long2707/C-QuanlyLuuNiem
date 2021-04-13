using System;
using System.Collections.Generic;
using System.Text;

namespace c3
{
    class hcn
    {
        private float with;
        private float height;
        public void nhap()
        {
            Console.WriteLine("Nhap thong tin chieu rong: ");
            with = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin chieu dai: ");
            height = float.Parse(Console.ReadLine());
        }
        #region
        public void chuvi()
        {
            Console.WriteLine("chu vi hcn: {0}", ((with + height) / 2));

        }
      
        public float dt()
        {
            return with * height;
        }
        public hcn()
        {
            with = 1;
            height = 4;
        }
        public hcn(float _a, float _b)
        {
            with = _a;
            height = _b;
        }
        public void inf(){
            Console.WriteLine("{0} {1}", with, height);
            }
        #endregion
        public hcn(hcn h)
        {
            with = h.with;
            height = h.height;
        }
    }
}
