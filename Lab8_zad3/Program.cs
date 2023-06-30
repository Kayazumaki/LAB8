using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_zad3
{
    using System;

    

    enum Rzadkosc
    {
        Sztampowy,
        Cudaczny,
        Legendarny,
        Epicki
    }

    enum TypPrzedmiotu
    {
        Miecz,
        Kapelusz,
        Tarcza,
        Gaciolandia,
        CzapkaZGumek,
        ButyKosmosu,
        AmuletNiewidzialnosci
    }

    struct Przedmiot
    {
        public double Waga;
        public int Wartosc;
        public Rzadkosc Rzadkosc;
        public TypPrzedmiotu Typ;
        public string NazwaWlasna;

        public void WypelnijPrzedmiot(double waga, int wartosc, Rzadkosc rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
        {
            Waga = waga;
            Wartosc = wartosc;
            Rzadkosc = rzadkosc;
            Typ = typ;
            NazwaWlasna = nazwaWlasna;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Przedmiot:");
            Console.WriteLine("Nazwa: " + NazwaWlasna);
            Console.WriteLine("Typ: " + Typ);
            Console.WriteLine("Rzadkosc: " + Rzadkosc);
            Console.WriteLine("Waga: " + Waga);
            Console.WriteLine("Wartosc: " + Wartosc);
            Console.WriteLine();
        }
    }

    class Program
    {
        static Random random = new Random();

        static Przedmiot WylosujPrzedmiot(Przedmiot[] przedmioty)
        {
            double losowaWartosc = random.NextDouble();
            double sumaPrawdopodobienstw = 0;

            foreach (var przedmiot in przedmioty)
            {
                sumaPrawdopodobienstw += (int)przedmiot.Rzadkosc / 10.0;

                if (losowaWartosc <= sumaPrawdopodobienstw)
                    return przedmiot;
            }

            return przedmioty[random.Next(przedmioty.Length)];
        }

        static void Main(string[] args)
        {
            Przedmiot[] przedmioty = new Przedmiot[4];

            przedmioty[0].WypelnijPrzedmiot(2.5, 50, Rzadkosc.Sztampowy, TypPrzedmiotu.Miecz, "Zwykły Miecz");
            przedmioty[1].WypelnijPrzedmiot(1.2, 100, Rzadkosc.Cudaczny, TypPrzedmiotu.Kapelusz, "Kapelusz Szaleństwa");
            przedmioty[2].WypelnijPrzedmiot(0.5, 200, Rzadkosc.Legendarny, TypPrzedmiotu.Tarcza, "Tarcza Północy");
            przedmioty[3].WypelnijPrzedmiot(0.8, 150, Rzadkosc.Epicki, TypPrzedmiotu.Gaciolandia, "Gaciolandzkie Majtki");

            Przedmiot losowyPrzedmiot = WylosujPrzedmiot(przedmioty);
            losowyPrzedmiot.WyswietlInformacje();

            Console.ReadKey();
        }
    }

}
