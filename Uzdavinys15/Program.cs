using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 dalis
            for (int i = 0; i <=10;  i++) 
            { 
                 Console.WriteLine(i);
            }
            // 2 dalis
            for (int a = 0; a < 15;  a +=2 ) 
            {
                Console.Write($" {a}");
            }
            Console.WriteLine();
            // 3 dalis
            for (int b = 0; b < 20; b += 3)
            {
                Console.Write($"[{b}]");
            }
            Console.WriteLine() ;
            // 4 dalis
            //for (int x = 0; x < 11; x++) ;
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.Write($"Išvesti lyginiai skaičiai: {x} ");
            //    }
            //}

        }
    }
}
