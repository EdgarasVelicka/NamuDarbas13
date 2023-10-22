using System;


namespace Uzdavinys07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            // Vardo ir amžiaus įvedimas
            Console.Write("Įveskite savo vardą ir amžių: ");
            string vardas = Console.ReadLine();
            var amzius = Console.ReadLine();
            Console.WriteLine($"Jūsų vardas: {vardas}, o amžius: {amzius}");
            Console.WriteLine();

            // kvadratas
            Console.WriteLine("Kvadratas iš įvesto simbolio: ");
            Console.WriteLine("Įveskite simbolį: ");
            var simbolis = Console.ReadLine(); ;
            Console.WriteLine();

            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine();

            // Trijų skaičių suma 
            Console.WriteLine("Įvestų skaičių suma");
            Console.Write("Įveskite pirmą skaičių:  "); var pirmasdemuo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių:  "); var antrasdemuo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių:  "); var treciasdemuo = Convert.ToDouble(Console.ReadLine());
            var suma = pirmasdemuo + antrasdemuo + treciasdemuo;
            Console.WriteLine($" Įvestų skaičių suma: {pirmasdemuo} + {antrasdemuo} + {treciasdemuo} = {suma}");
        }
    }
}
