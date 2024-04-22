using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
        }

        public int[] Tworzenie_tablicy()
        {
            Console.Write("Ile znaków ma mieć tablica? : ");
            int n = int.Parse(Console.ReadLine());

            int[] tablica = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj liczbe do tablicy: ");
                tablica[i] = int.Parse(Console.ReadLine());
            }
            return tablica;
        }

        public void SorotowanieBombelkowe(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length -i; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int x = tab[j-1];
                        tab[j-1] = tab[j];
                        tab[j] = x;
                    }
                }
            }
        }
    }

    
}
