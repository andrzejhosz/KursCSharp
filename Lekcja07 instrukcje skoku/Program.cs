using System;

namespace Lekcja7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            while (true)
            {
                if (a > 10)
                {
                    break;
                }
                Console.WriteLine(a);
                a++;
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


        jeden:
            Console.WriteLine("Jeden");
            goto trzy;
        dwa:
            Console.WriteLine("Dwa");
        trzy:
            Console.WriteLine("Trzy");

            Console.ReadKey();
        }
    }
}
