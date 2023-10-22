using System;


namespace Uzdavinys09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Amžiaus įvedimas
            Console.Write("Įveskite kiek Jums metų: "); int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }
            Console.WriteLine();

            // Skaiciaus palyginimas
            Console.Write("Įveskite skaičių: "); int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Tu kvailys!!!");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Sveikiname");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Skaičius {skaicius} yra lyginis ");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine($"Skaičius {skaicius} dalijasi iš 4 ");
            }
            if (skaicius > 10)
            {
                Console.WriteLine($"Skaičius {skaicius} didesnis uz 10 ");
            }
            Console.WriteLine();

            // Pažymių vidurkis
            Console.WriteLine("Pažymių vidurkis");
            Console.Write("Įveskite 1 pažymį: "); int pirmpazymys = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite 2 pažymį: "); int antrpazymys = Convert.ToInt32(Console.ReadLine());
            double vidurkis = (pirmpazymys + antrpazymys) / 2;
            Console.WriteLine($"Pažymių vidurkis: {vidurkis}");
            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio");
            }
        }
    }
}
