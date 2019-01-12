using System;
using System.Collections;

namespace Lekcja20
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);  // dodawanie do listy
            list.Add("Bartek");
            list.Add(new Auto("BMW"));

            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(1); //zmniejszy się rozmiar listy oraz indeksy się ustawią po kolei

            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list[1]);

            list.Insert(0, "Ala"); //wstawianie w dowolnym miejscu

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Clear(); //czyszczenie listy

           
            Console.WriteLine(list.Count);
           

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {

        Nazwa = marka;

        }
        public override string ToString()
        {
            return Nazwa;
        }
    }

    
}
