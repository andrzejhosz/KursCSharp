using System;

namespace Lekcja14
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie + " " + adi.nazwisko);
            adi.imie = "Bartek";
            Console.WriteLine(adi.imie + " " + adi.nazwisko);
            
            Czlowiek adi2 = new Czlowiek();
            Console.WriteLine(adi2.imie + " " + adi.nazwisko);

            adi.PrzedstawSie();
            adi2.PrzedstawSie();


            Console.ReadKey();
        }
    }

    
}
