using System;

namespace Ukol_18_4_24_Priklad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int tajneCislo = random.Next(1, 10);
            Console.WriteLine("Hádej číslo, které si myslím (mezi 1 a 10).");
            
            int pokus = 0;
            while (pokus != tajneCislo)
            {
                Console.Write("Zadej tvůj tip: ");
                string vstup = Console.ReadLine();
                
                if (!int.TryParse(vstup, out pokus))
                {
                    Console.WriteLine("Tohle není platné číslo, zkuste to znovu.");
                    continue;
                }
                
                if (pokus < tajneCislo)
                {
                    Console.WriteLine("Netrefil jsi se, mé číslo je větší.");
                }
                else if (pokus > tajneCislo)
                {
                    Console.WriteLine("Netrefil jsi se, mé číslo je menší.");
                }
            }
            Console.WriteLine("Gratulujeme! Uhádl jsi správné číslo!");
        }
    }
}
