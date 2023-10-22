using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė ");
            Console.Write("Įveskite pasirinkimo numerį: "); int numeris = Convert.ToInt32(Console.ReadLine());
            switch (numeris)
            {
                case 1:
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose ar darbo vietoje");
                    break;
                case 2:
                    Console.WriteLine("Nešiojamu kompiuteriu galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("Planšete galite naudotis visur");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }

        }
    }
}
