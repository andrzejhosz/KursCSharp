using System;

namespace Lekcja15
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            adi.PrzedstawSie();
            adi.imie = "Bartek";
            adi.PrzedstawSie();
            Czlowiek adi1 = new Czlowiek("Andrzej");
            adi1.PrzedstawSie();
            Czlowiek adi2 = new Czlowiek("Andrzej", "H");
            adi2.PrzedstawSie();

            
            Console.ReadKey();
        }
    }
}
