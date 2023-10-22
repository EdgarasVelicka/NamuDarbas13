using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Pitagoro teorema
            Console.Write("Įveskite pirmos kraštinės ilgį: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite antros kraštinės ilgį: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Įžambinės ilgis: {Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2))}");
        }
    }
}
