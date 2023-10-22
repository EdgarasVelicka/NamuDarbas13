

using System;

namespace Uzdavinys08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Sveikojo skaičiaus daugybos lentelė
            Console.Write("Įveskite sveikąjį skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int daugiklis = 1;
            Console.WriteLine($"Skaičiaus {skaicius} daugybos lentelė");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            // Skaičiu vidurkis
            Console.WriteLine("Trijų skaičių vidurkis");
            Console.WriteLine();
            Console.Write("Įveskite pirmą skaičių: "); double pirmassk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: "); double antrassk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: "); double treciassk = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (pirmassk + antrassk + treciassk) / 3;
            Console.WriteLine();
            Console.WriteLine($"Įvestų skaičių vidurkis: {vidurkis}");
            Console.WriteLine();
            // Skaičiai pakelti kvadratu, kubu ir padalinti iš dviejų
            Console.WriteLine("Įvesti skaičiai, jų reikšmės kvadratu, kubu ir reikšmės padalinus iš 2");
            Console.Write("Įveskite pirmą skaičių: "); double pirmas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: "); double antras = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite trečią skaičių: "); double trecias = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Skaičius: {pirmas}, pakeltas kvadratu: {Math.Pow(pirmas, 2)}, pakeltas kubu: {Math.Pow(pirmas, 3)}, padalintas iš 2: {pirmas / 2}");
            Console.WriteLine($"Skaičius: {antras}, pakeltas kvadratu: {Math.Pow(antras, 2)}, pakeltas kubu: {Math.Pow(antras, 3)}, padalintas iš 2: {antras / 2}");
            Console.WriteLine($"Skaičius: {trecias}, pakeltas kvadratu: {Math.Pow(trecias, 2)}, pakeltas kubu: {Math.Pow(trecias, 3)}, padalintas iš 2: {trecias / 2}");
        }
    }
}
