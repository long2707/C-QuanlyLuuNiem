using System;

namespace test
{
    class Program
    {
        private const string Value = "Toi co {0,8:c},";

        static void Main(string[] args)
        {
            
            string ten = " Tran Van Long";
            int tuoi = 69;
            int sotien = 10000;

            Console.WriteLine("Ten toi la {0} toi {1} tuoi", ten, tuoi);
            Console.WriteLine("Toi co {0,8:c}", sotien);
            Console.Read();
        }
    }
}
