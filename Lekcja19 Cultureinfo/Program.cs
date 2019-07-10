using System;
using System.Globalization;

namespace Lekcja19_Cultureinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);

            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberDecimalSeparator = ":";
            newCulture.NumberFormat.NegativeSign = "MINUS";
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;

            Console.WriteLine($"{a}\n{b}");

            Console.ReadKey();
        }
    }
}
