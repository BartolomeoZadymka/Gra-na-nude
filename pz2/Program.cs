using System;

namespace GraTekstowa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy zmienne przechowujące stan gry
            int zycia = 3;
            int skarby = 0;
            bool czyGraTrwa = true;

            // Opisujemy początkową sytuację
            Console.WriteLine("Jesteś w ciemnym lochu pełnym niebezpieczeństw.");
            Console.WriteLine("Masz {0} żyć i {1} skarbów.", zycia, skarby);
            Console.WriteLine("Aby poruszać się po lochu, wpisz 'idź na północ', 'idź na południe', 'idź na wschód' lub 'idź na zachód'.");

            // Pętla główna gry
            while (czyGraTrwa)
            {
                // Czekamy na polecenie gracza
                Console.Write("> ");
                string polecenie = Console.ReadLine();

                // Obsługujemy polecenie gracza
                if (polecenie == "idź na północ")
                {
                    Console.WriteLine("Idziesz na północ i natykasię na potwora.");
                    Console.WriteLine("Co chcesz zrobić? [walcz/uciekaj]");

                    string decyzja = Console.ReadLine();
                    if (decyzja == "walcz")
                    {
                        Console.WriteLine("Walczysz z potworem i wygrywasz!");
                        skarby++;
                        Console.WriteLine("Zdobywasz skarb. Masz teraz {0} skarbów.", skarby);
                    }
                    else if (decyzja == "uciekaj")
                    {
                        Console.WriteLine("Uciekasz przed potworem, ale tracisz 1 życie. Masz teraz {0} żyć.", --zycia);
                    }
                    else
                    {
                        Console.WriteLine("Nie rozumiem polecenia.");
                    }
                }
                else if (polecenie == "idź na południe")
                {
                    Console.WriteLine("Idziesz na południe i znajdujesz skarb.");
                    skarby++;
                    Console.WriteLine("Zdobywasz skarb. Masz teraz {0} skarbów.", skarby);
                }
                else if (polecenie == "idź na wschód")
                {
                    Console.WriteLine("Idziesz na wschód i trafiasz na pułapkę. Tracisz 1 życie.Masz teraz { 0}żyć.", --zycia);
                }
                else if (polecenie == "idź na zachód")
                {
                    Console.WriteLine("Idziesz na zachód i znajdujesz wyjście z lochu.");
                    Console.WriteLine("Gratulacje! Udało Ci się zdobyć {0} skarbów i przeżyć w lochu.", skarby);
                    czyGraTrwa = false;
                }
                else
                {
                    Console.WriteLine("Nie rozumiem polecenia.");
                }
                // Sprawdzamy, czy gracz nie zginął lub nie wyszedł z lochu
                if (zycia <= 0)
                {
                    Console.WriteLine("Niestety, zginąłeś. Koniec gry.");
                    czyGraTrwa = false;
                }
            }
        }
    }
}