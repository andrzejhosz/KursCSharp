using System;
using System.Collections.Generic;
using System.Text;

namespace Lekcja15
{
    class Czlowiek
    {
        public Czlowiek(string imieKonstruktora)  // konstruktor
        {
            imie = imieKonstruktora;
        }
        public Czlowiek()  // konstruktor
        {

        }
        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)  // konstruktor
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }

        public string imie = "Adrian";
        public string nazwisko = "Kowalski";

        public void PrzedstawSie()
        {
            Console.WriteLine(imie + nazwisko);
        }

        ~Czlowiek()  //destruktor
        {
            System.Diagnostics.Trace.WriteLine("Jestem destruktorem");
            
        }
    }
}
