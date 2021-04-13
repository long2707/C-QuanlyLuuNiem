using System;
using System.Collections.Generic;
using System.Text;

namespace b3
{
    class Mang1Chieu
    {
        private int n;
        int[] a;
        public Mang1Chieu(int n)
        {
            n = 0;
         
        }
        public void nhapMang(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap phan tu thu {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void inMang(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
        }
        public void sapXep(int thutu)
        {
            
           switch (thutu){
                case 1:
                    {
                        Console.Write("sap xep tang dan: ");
                        Array.Sort(a);
                        break;
                    }
                case 0:
                    {
                        Console.Write("sap xep giam dan: ");
                        for (int i = 0; i < a.Length; i++)
                        {
                            for (int j = i+1; j< a.Length; j++)
                            {
                                if (a[i] < a[j])
                                {
                                    int tmp = a[i];
                                    a[i] = a[j];
                                    a[j] = tmp;
                                }
                            }
                        }
                        break;
                    }
            }

        }
        public void TimKiem(int n)
        {

        }
    }
}
