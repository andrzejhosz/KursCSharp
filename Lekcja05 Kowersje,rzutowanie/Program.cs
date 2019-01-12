using System;

namespace Lekcja5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl + k ctrl + d- układanie kodu
            // ctrl + k ctrl + c- komentowanie
            // ctrl + k ctrl + u- odkomentowanie
            // F5 - kompilacja
            // cw tab tab = Console.WriteLine();
            // for tab tab - edytowalna pętla for
            // while tab tab - pętla nieskończona

            // RZUTOWANIE

            int i = int.MaxValue;
            short s = short.MaxValue;
            double d = 5.9;
            
            i = s;
            s = (short)i;
            i = (int)d;

            // WCZYTYWANIE DANYCH Z KONSOLI

            Console.WriteLine("Podaj swoje imię");
            string imie = Console.ReadLine();
            Console.WriteLine("Masz na imię :" + imie);

            // KONWERSJA INT>STRING STRING>INT

            string tekst = "Tekst";
            int a = int.Parse(tekst);

            int liczba = 1;
            string c;
            c = liczba.ToString();

            //UŻYWANIE KONSOLI

            string t1 = "jest";
            string t2 = "tekst";
            string t3 = "na";

            Console.WriteLine("To jest przykładowy tekst wyświetlony na ekranie");
            Console.WriteLine("To {0} przykładowy {1} wyświetlony {2} ekranie", t1, t2, t3);
            Console.WriteLine("To " + t1 + "przykładowy " + t2 + "wyświetlony " + t3 + "ekranie");

            // \n nowa linia

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
