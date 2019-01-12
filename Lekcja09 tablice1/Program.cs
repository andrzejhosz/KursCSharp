using System;

namespace Lekcja9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dniWRoku = new int[365]; //tworzenie tablicy
            string[] poryRoku = new string[4];
            string[] dniTygodnia = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

            dniWRoku[0] = 22;  //uzupełnianie tablicy

            for (int i = 0; i < dniTygodnia.Length; i++)
            {
                Console.WriteLine(dniTygodnia[i]);
            }            
            Console.ReadKey();
                    }
    }
}
