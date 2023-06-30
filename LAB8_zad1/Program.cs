using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_zad1
{
    internal class Program
    {
        
        
        enum DniTygodnia
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }

        enum EtapyPrania
        {
            WstepnePlukanie,
            GłownePranie,
            Plukanie,
            Wirowanie,
            Suszenie
        }

        enum PosilkiDnia
        {
            Sniadanie,
            DrugieSniadanie,
            Obiad,
            Podwieczorek,
            Kolacja
        }

        enum BiurkiSzachowe
        {
            A1, B1, C1, D1, E1, F1, G1, H1,
            A2, B2, C2, D2, E2, F2, G2, H2,
            A3, B3, C3, D3, E3, F3, G3, H3,
            A4, B4, C4, D4, E4, F4, G4, H4,
            A5, B5, C5, D5, E5, F5, G5, H5,
            A6, B6, C6, D6, E6, F6, G6, H6,
            A7, B7, C7, D7, E7, F7, G7, H7,
            A8, B8, C8, D8, E8, F8, G8, H8
        }
        //W przypadku dni tygodnia, etapów prania i posiłków w ciągu dnia nie ma potrzeby duplikowania klucza,
        //ponieważ te wartości są unikalne. Jednak w przypadku bierek szachowych klucz jest duplikowany,
        //ponieważ oznaczenia bierek na szachownicy powtarzają się na różnych wierszach.
        static void Main()
        {
            Console.WriteLine("Dni tygodnia:");
            foreach (DniTygodnia dzien in Enum.GetValues(typeof(DniTygodnia)))
            {
                Console.WriteLine(dzien);
            }

            Console.WriteLine("\nEtap prania:");
            foreach (EtapyPrania etap in Enum.GetValues(typeof(EtapyPrania)))
            {
                Console.WriteLine(etap);
            }

            Console.WriteLine("\nPosilki w ciagu dnia:");
            foreach (PosilkiDnia posilek in Enum.GetValues(typeof(PosilkiDnia)))
            {
                Console.WriteLine(posilek);
            }

            Console.WriteLine("\nBierki szachowe:");
            foreach (BiurkiSzachowe bierka in Enum.GetValues(typeof(BiurkiSzachowe)))
            {
                Console.WriteLine(bierka);

            }
            Console.ReadKey();
        }

    }
}
