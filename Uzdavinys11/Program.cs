using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            // 2 dalis 
            Console.Write("Įveskite šios dienos temperatūrą: "); double temp = Convert.ToDouble(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Žiauriai šalta");
            }
            else if (temp < 10)
            {
                Console.WriteLine("labai šalta");
            }
            else if (temp < 20)
            {
                Console.WriteLine("šalta");
            }
            else if (temp < 30)
            {
                Console.WriteLine("normli temperatūra");
            }
            else if (temp < 40) 
            {
                Console.WriteLine("karšta");
            }
            else if (temp >= 40) 
            {
;                Console.WriteLine("labai degina");
            }
            
        }
           
            
    }
}
