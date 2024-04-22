using ConsoleApp1;

class PlikGlowny
{
    static void Main(string[] args)
    {
        Tablice tablica = new Tablice();
        int[] tab = tablica.Tworzenie_tablicy();

        tablica.Wyswietl(tab);
        tablica.SorotowanieBombelkowe(tab);
        tablica.Wyswietl(tab);
        tablica.Przeszukaj(tab);
    }
}