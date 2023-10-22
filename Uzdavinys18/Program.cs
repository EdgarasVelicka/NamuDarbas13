using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdavinys18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Kepykla
            Console.Write("Įveskite, kiek duonos kepalų darbuotojas gali iškepti per valandą: "); double duon = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite, kiek darbuotojų turi kepykla: "); int darb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo savikainą: "); double savkaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo pardavimo kainą: "); double kaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite, kiek kepykla turi iškepti duonos kepalų per dieną: "); int kepal = Convert.ToInt32(Console.ReadLine());
            double visikep = (duon * 8 * darb);
            Console.WriteLine();
            Console.WriteLine($"Kepykla, per dieną sugebėjo iškepti: {visikep} duonos kepalų");
            if (visikep < kepal) 
            {
                Console.WriteLine($"Kepykla nespėjo iškepti: {kepal - visikep} duonos kepalų" );
            }
            else
            {
                Console.WriteLine("Kepykla spėjo iškepti visus dienos užsakymus");
            }
            Console.WriteLine($"Kepykla uždirbo: {visikep * (kaina - savkaina)}");

        }
    }
}
