using System;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {

            float a = 2; //float tylko dlatego że dzielenie by nie wyszło
            float b = 3;

            float c = a + b;
            float d = a - b;
            float e = a * b;
            float f = a / b;
            float g = a % b;

            a += b; //a = a + b
            a -= b; //a = a - b
            a *= b; //a = a * b
            a /= b; //a = a / b
            a %= b; //a = a % b

            a++; //inkrementacja
            a--; //dekrementacja

            bool h = a == b;
            bool i = a <= b;
            bool j = a >= b;
            bool k = a != b;

            bool l = 1 == 1 && 2 == 2; //koniunkcja jest wyżej w hierarchii od alternatywy
            bool m = 1 == 1 || 2 == 2; //alternatywa

            Math.Pow(a, b);
            Math.Sqrt(a);
            Math.Abs(a);
                                
            Console.ReadKey();
        }
    }
}
