using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Mažėjimo ciklas
            Console.Write("Įveskite teigiamą skaičių: "); int skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius >= 0)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }
            Console.WriteLine();
            // Didėjimo ciklas
            Console.Write("Įveskite neigiamą skaičių: "); int neigiamas = Convert.ToInt32(Console.ReadLine());
            while (neigiamas <= 0)
            {
                Console.WriteLine(neigiamas);
                neigiamas++;
            }
            Console.WriteLine();
            //// Skaičiuotuvas
            //Console.WriteLine("Skaičiuotuvas");
            //Console.Write("Įveskite pirmą skaičių: "); int pirm = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Įveskite antrą skaičių: "); int antr = Convert.ToInt32(Console.ReadLine());
            //int suma = pirm + antr;
            //int skirtumas = pirm - antr;
            //int sandauga = pirm * antr;
            //int dalyba = pirm / antr;
            //while (pirm= 1&& antr =2)
            //{
            //    Console.WriteLine("Įvestų skaičių suma: " + suma); 
            //    Console.WriteLine("Įvestų skaičių skirtumas: " + skirtumas);
            //    Console.WriteLine("Įvestų skaičių sandauga: " + sandauga);
            //    Console.WriteLine("Įvestų skaičių dalmuo: " + dalyba);
            //}


        }
    }
}
