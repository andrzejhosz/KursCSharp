using System;

namespace Lekcja8
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj dowolną liczbę dodatnią: ");
            liczba = int.Parse(Console.ReadLine());

            char znak = 'a';

            switch (liczba) // (znak)
            {
                case 1:
                    Console.WriteLine("Jeden");
                    goto koniec;

                case 2:
                    Console.WriteLine("Dwa");
                    goto case 3;

                case 3:
                    Console.WriteLine("Trzy");
                    break;

                //case 'a':
                //    Console.WriteLine("A");
                //    break;

                default:
                    Console.WriteLine("Inna liczba");
                    break;
            }
            Console.WriteLine("Dodatkowy tekst");
            koniec:
            Console.WriteLine("Koniec");
            
            Console.ReadKey();

        }
    }
}
