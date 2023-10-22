using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Įveskite tris skaičius: ");
            Console.Write("Pirmas skaičius: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaičius: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Trečias skaičius: "); int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"skaičius {a} didesnis už {b}");
            }
            else if (b > c)
            {
                Console.WriteLine($"skaičius {b} didesnis už {c}");
            }
            else if (a < c)
            {
                Console.WriteLine($"skaičius {a} mažesnis už {c}");
            }
            else if (a == b) 
            {
                Console.WriteLine($"skaičius {a} lygus {b}");
            }
        }
           
            
    }
}
