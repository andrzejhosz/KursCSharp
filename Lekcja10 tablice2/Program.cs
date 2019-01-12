using System;

namespace Lekcja10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[2, 3];
            tab[0, 0] = 1;
            tab[0, 1] = 2;
            tab[0, 2] = 5;
            tab[1, 0] = 22;
            tab[1, 1] = 33;
            tab[1, 2] = 44;

            Console.WriteLine(tab.GetLength(0));
            Console.WriteLine(tab.GetLength(1));

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] tab1 = new int[2][];
            tab1[0] = new int[3];
            tab1[1] = new int[2];
            tab1[0][0] = 2;
            tab1[0][1] = 5;
            tab1[0][2] = 3;
            tab1[1][0] = 32;
            tab1[1][1] = 42;

            Console.WriteLine(tab1.GetLength(0));

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1[i].Length; j++)
                {
                    Console.Write(tab1[i][j]+" ");
                }
                Console.WriteLine();
            }

            
            Array.Sort(tab);
            Array.Reverse(tab);

            Console.ReadKey();
        }
    }
}
