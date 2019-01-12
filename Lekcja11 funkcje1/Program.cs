using System;

namespace Lekcja_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 4;
            Dodaj(2, c);
            Dodaj(2, c, 3);
            Dodaj(2, c = 3, c);
            Dodaj(2, c, c: 5);

            Console.ReadKey();
        }

        static void Dodaj(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }

        static void Dodaj(int a, int b, int c)
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }

       
    }
}
