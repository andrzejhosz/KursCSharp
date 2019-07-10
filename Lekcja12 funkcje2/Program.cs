using System;

namespace Lekcja12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(2, 4));
            Console.WriteLine(DodajTekst(2, 4));

            Console.ReadKey();
        }

        static int Dodaj(int a, int b)
        {
            int wynik = a + b;
            if (wynik >= 10)
            {
                return wynik;  //wszystkie scieżki muszą dać wynik
            }
            else
            {
                return wynik;
            }
        }

        static string DodajTekst(int a, int b)
        {
            int wynik = a + b;
            if (wynik >= 10)
            {
                return "wynik wiekszy od 10";
            }
            else
            {
                return "wynik mniejszy od 10";
            }
        }
    }
}
