using System;

namespace Lekcja4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //a dostępne globalnie
            while(a < 5)
            {
                Console.WriteLine(a);
                a++;
            }

            //int b = 0; //b dostępne globalnie
            //for (; b < 5;b++)  
            for(int b = 0;b < 5 ;b++) //b dostępne lokalnie
            {
                Console.WriteLine(b);
            }

            int c = 0;
            do
            {
                Console.WriteLine(c);
            }
            while(false);
            Console.ReadKey();
        }
    }
}
