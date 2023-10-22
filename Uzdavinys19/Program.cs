using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uzdavinys19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // for ciklas
            int kiekis = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16  == 0) 
                kiekis++;
            }
            Console.WriteLine("Skaičiaus 16 kartotiniai nuo 0 iki 1000: " + kiekis);
            Console.WriteLine();
            // while ciklas
            int laips = 1;
            Console.Write("Įveskite teigiamą skaičių: "); int skaicius = Convert.ToInt32(Console.ReadLine());
            //while ( Math.Pow (skaicius, laips++ ) <= 1500) 
            //{
            //    Console.WriteLine(skaicius);
            //    skaicius++;

            }
        }
    }
}
