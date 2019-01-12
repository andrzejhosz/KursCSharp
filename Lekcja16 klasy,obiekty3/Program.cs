using System;

namespace Lekcja16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci); //static można zmodyfikowac 
            CzlowiekStatic.liczbaLudnosci = 10000;
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);

            Czlowiek czlowiek = new Czlowiek(); //nie static zachowuje swoje wartości
            Console.WriteLine(czlowiek.imie);
            Console.WriteLine(Czlowiek.nazwisko);//jeśli zmienna jest static, od razu dostępna
            czlowiek.imie = "Marek";
            Console.WriteLine(czlowiek.imie);
            Czlowiek czlowiek2 = new Czlowiek();
            Console.WriteLine(czlowiek2.imie);
            

            Console.ReadKey();
        }
    }
}
