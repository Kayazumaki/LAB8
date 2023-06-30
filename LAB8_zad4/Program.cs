using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_zad4
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;

        public void WypelnijStudenta()
        {
            Console.Write("Podaj nazwisko studenta: ");
            Nazwisko = Console.ReadLine();

            Console.Write("Podaj numer albumu: ");
            int.TryParse(Console.ReadLine(), out NrAlbumu);

            Console.Write("Podaj ocenę: ");
            double.TryParse(Console.ReadLine(), out Ocena);
            Ocena = Math.Max(2.0, Math.Min(5.0, Ocena));

            Console.Write("Podaj płeć (0 - Mezczyzna, 1 - Kobieta): ");
            int plecInput;
            int.TryParse(Console.ReadLine(), out plecInput);
            Plec = (Plec)plecInput;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwisko: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
        }
    }

    class Program
    {
        static double ObliczSrednia(Student[] grupa)
        {
            double suma = 0;
            foreach (var student in grupa)
            {
                suma += student.Ocena;
            }

            return suma / grupa.Length;
        }

        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            for (int i = 0; i < grupa.Length; i++)
            {
                Console.WriteLine($"Dane studenta {i + 1}:");
                grupa[i].WypelnijStudenta();
            }

            foreach (var student in grupa)
            {
                student.WyswietlInformacje();
            }

            double srednia = ObliczSrednia(grupa);
            Console.WriteLine($"Średnia ocen: {srednia}");

            Console.ReadKey();
        }
    }
}
