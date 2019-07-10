using System;

namespace Lekcja17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerujTekst("Mam na imię #0 i mam #1 lat", "Adam", 22));

            Console.ReadKey();
        }

        public static string GenerujTekst(string tekst, params object[] args) //object przechowuje wszystkie typy danych       {
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#"+i,args[i].ToString()); //zmienia dowolne znaki na string
            }

            return tekst;
        }
    }
}
