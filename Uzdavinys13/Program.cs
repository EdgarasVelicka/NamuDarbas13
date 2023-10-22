using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Įveskite tris skaičius: ");
            Console.Write("Pirmas skaičius: "); int pirm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaičius: "); int antr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Trecias skaičius: "); int trec = Convert.ToInt32(Console.ReadLine());
            switch (pirm) 
            {
                case 1:
                    Console.WriteLine($"Išvedama visų skaičių suma: {pirm + antr + trec}");
                    break;
                case 2:
                    Console.WriteLine($"Išvedamas pirmo ir trecio skaičių skirtumas: {pirm - trec}");
                    break;
                case 3:
                    Console.WriteLine($"Išvedama antro ir trečio skaičių sandauga: {antr * trec}");
                    break;
            }
        }
    }
}
