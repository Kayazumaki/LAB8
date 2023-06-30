using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_zad2
{
    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public string Kierunek;
        public int Semestr;
        public string Adres;

        public void WpiszDaneStudenta()
        {
            Console.WriteLine("Wprowadź dane studenta:");
            Console.Write("Imię: ");
            Imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            Nazwisko = Console.ReadLine();
            Console.Write("Numer indeksu: ");
            NumerIndeksu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kierunek: ");
            Kierunek = Console.ReadLine();
            Console.Write("Semestr: ");
            Semestr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adres: ");
            Adres = Console.ReadLine();
        }

        public void WyswietlDaneStudenta()
        {
            Console.WriteLine("Dane studenta:");
            Console.WriteLine("Imię: " + Imie);
            Console.WriteLine("Nazwisko: " + Nazwisko);
            Console.WriteLine("Numer indeksu: " + NumerIndeksu);
            Console.WriteLine("Kierunek: " + Kierunek);
            Console.WriteLine("Semestr: " + Semestr);
            Console.WriteLine("Adres: " + Adres);
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.WpiszDaneStudenta();
            Console.WriteLine();
            student.WyswietlDaneStudenta();
        }
    }
}

