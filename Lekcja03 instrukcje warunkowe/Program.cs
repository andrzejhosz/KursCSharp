using System;

namespace Lekcja3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            if(a>0)
            {
                Console.WriteLine("a jest większe od 0");
            }
            else if (a == 0)
            {
                Console.WriteLine("a jest równe 0");
            }
            else
            {
                Console.WriteLine("a jest mniejsze od 0");
            }

            Console.ReadKey();
        }
    }
}
