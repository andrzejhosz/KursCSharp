using System;

namespace Lekcja6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość prostokąta :");
            string x = Console.ReadLine();
            int a = int.Parse(x);

            Console.Write("Podaj szerokość prostokąta :");
            string y = Console.ReadLine();
            int b = int.Parse(y);

            int i;
            int j;

            for (i=0; i < a; i++)
            {
                for (j=0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            

            Random losowa = new Random();
            int l = losowa.Next(1, 11);

            int liczba;

            do
            {
                Console.Write("Zgadnij jaką wylosowałem liczbę z zakresu 1-10: ");
                string liczba1 = Console.ReadLine();
                liczba = int.Parse(liczba1);

                if (liczba < 1 || liczba > 10)
                {
                    Console.WriteLine("Nie podałeś liczby z właściwego zakresu!");
                }
                else if (liczba < l)
                {
                    Console.WriteLine("Podałeś zbyt małą liczbę!");
                }
                else if (liczba > l)
                {
                    Console.WriteLine("Podałeś zbyt dużą liczbę!");
                }
                else
                {
                    Console.WriteLine("Brawo!! odgadłeś liczbę !!");
                }
            }

            while (liczba != l);

            Console.ReadKey();        }
    }
}
