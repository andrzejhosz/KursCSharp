using System;

namespace Lekcja1
{
    class Program
    {
        static void Main(string[] args)
        {

            //CAŁKOWITE
            sbyte zmienna1 =sbyte.MaxValue;
            byte zmienna1_1 = byte.MaxValue;
            short zmienna2 = short.MaxValue;
            ushort zmienna2_1 = ushort.MaxValue;
            int zmienna3 = int.MaxValue;
            uint zmiena3_1 = uint.MaxValue;
            long zmienna4 = long.MaxValue;
            ulong zmienna4_1 = ulong.MaxValue;

            //ZMIENNOPRZECINKOWE
            float zmienna5 = float.MaxValue;
            zmienna5 = 1.1234F;
            double zmienna6 = double.MaxValue;
            zmienna6 = 1.1234;
            decimal zmienna7 = decimal.MaxValue;
            zmienna7 = 1.1234M;

            //TEKSTOWE
            string zmienna8 = "Tekst";
            char zmienna9 = 't';

            //LOGICZNE
            bool zmienna10 = false;
            bool zmienna10_1 = true;

            //STAŁA

            const int zmienna11 = 111;
            const float PI = 3.14F;

            Console.ReadKey();
        }
    }
}
