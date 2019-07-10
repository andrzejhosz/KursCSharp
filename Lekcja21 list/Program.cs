using System;
using System.Collections.Generic;

namespace Lekcja21
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> list = new List <int>();
            list.Add(2);
            list.Add(5);

            List<Auto> list1 = new List<Auto>();
            list1.Add(new Auto("BMW"));
            list1.Add(new Auto("Mercedes"));

            foreach (Auto item in list1)
            {
                Console.WriteLine(item.Nazwa);
            }
           

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
