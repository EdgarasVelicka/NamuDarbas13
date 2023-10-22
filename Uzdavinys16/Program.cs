using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Skaičių nuo 1 iki 100 suma
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Visų skaičių nuo 1 iki 100 suma: " + suma);
            Console.WriteLine();
            // Lyginių skaičių nuo 20 iki 40 suma
            int sum = 0;
            for (int a = 20; a < 41; a++)
            { 
               if (a % 2 == 0) 
                {
                    sum += a;
                }
            }
            Console.WriteLine("Lyginių skaičių nuo 20 iki 40 suma:" + sum);
            Console.WriteLine();
            //Visų nelyginių nuo 30 iki 60 suma
            int skaicius = 0;
            for (int i = 30; i < 61; i++) 
            {
               if (i % 2 != 0) 
                {
                   skaicius += i;
                }
            }
            Console.WriteLine("Nelyginių skaičių nuo 30 iki 60 suma:" + skaicius);
            Console.WriteLine();
            // Visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą.
            int skait = 0;
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    skait += i;
                } 
            }
            Console.WriteLine("Visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą:" + skait);






        }
    }
}
