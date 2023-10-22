using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1 dalis
            Console.WriteLine("Įveskite tris skirtingus skaičius: ");
            Console.Write("Pirmas: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Antras: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Trečias: "); double c = Convert.ToDouble(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"Skaičius {a} yra didesnis už {b} ir {c}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"Skaičius {b} yra didesnis už {a} ir {c}");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"Skaičius {c} yra didesnis už {a} ir {b}");
            }
            Console.WriteLine();

            //  2 dalis 
            Console.Write("Įveskite egzamino rezultatą (nuo 1 iki 10): "); int rez = Convert.ToInt32(Console.ReadLine());
            if (8 <= rez && rez <= 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (5 <= rez && rez < 8)
            {
                Console.WriteLine($"Neblogai");
            }
            else
            {
                Console.WriteLine("Blogai");
            }







        }
    }
}
