using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Įveskite skaičių: "); int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Įvestas skaičius: {skaicius}, pakeltas 5 laipsniu: {Math.Pow(skaicius, 5)}");
            }
            if (skaicius % 4 != 0)
            {
                Console.Write("Įveskite kitą skaičių:"); int skaitmuo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Skaičių: {skaicius} ir {skaitmuo} suma: {skaicius + skaitmuo} ir sandauga: {skaicius * skaitmuo}");
            }
            

        }
    }
}
