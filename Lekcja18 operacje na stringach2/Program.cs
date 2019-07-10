using System;
using System.Text; // potrzebne dla funkcji StringBuilder

namespace Lekcja18
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = 100;

            Console.WriteLine(BudujString(ile));
            Console.WriteLine(BudujStringBuilder(ile));

            Console.ReadKey();
        }
        /// <summary>
        /// Metoda buduje string
        /// </summary>
        /// <param name="ile"> Podaj długość pętli</param>
        /// <returns>Zwracamy gotowy tekst</returns>
        public static string BudujString (int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string BudujStringBuilder(int ile)
        {
            string tekst = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }

            return stringBuilder.ToString();
        }
    }
}
