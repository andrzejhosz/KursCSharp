using System;

namespace Lekcja13_funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Przed: " + a);

            Test1(a);
            Console.WriteLine("Po Test1: " + a);

            Test2(ref a);
            Console.WriteLine("Po Test2: " + a);

            int b;

            Test3(out b);
            Console.WriteLine("Po Test3: " + b);

            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 2;

            Console.WriteLine("Przed: " + tab[0] + " " + tab[1]);
            Test4(tab);
            Console.WriteLine("Po: " + tab[0] + " " + tab[1]);

            Console.WriteLine("Przed: " + tab[0] + " " + tab[1]);
            Test5(tab);
            Console.WriteLine("Po: " + tab[0] + " " + tab[1]);

            Console.ReadKey();
        }

        static void Test1(int a) // a nie będzie zmodyfikowane
        {
            a += 5;
            Console.WriteLine("W funkcji Test1: " + a);
        }

        static void Test2(ref int a) // a będzie zmodyfikowane
        {
            a += 5;
            Console.WriteLine("W funkcji Test2: " + a);
        }

        static void Test3(out int b) // można najpierw wysłać pustą zmienną a w ciele nadać wartość
        {
            b = 5;
            b += 5;
            Console.WriteLine("W funkcji Test3: " + b);
        }

        static void Test4(int[] tab) // zmienne złożone typu tablice od razu się nadpisują
        {
            tab[0] = 555;
            tab[1] = 222;

            Console.WriteLine("W funkcji: " + tab[0] + " " + tab[1]);
        }

        static void Test5(int[] tab) // ale można zachować oryginał bez zmian tworząc kopię w ciele
        {
            tab = new int[2];
            tab[0] = -5;
            tab[1] = -2;

            Console.WriteLine("W funkcji: " + tab[0] + " " + tab[1]);
        }
    }
}
