using System;
using System.Collections.Generic;
using System.Text;

namespace konsolowa
{
    internal class TablicoweOperacje
    {
        private int[] _tablica;
        private int _rozmiarTablicy;

        public TablicoweOperacje(int rozmiarTablicy)
        {
            _rozmiarTablicy = rozmiarTablicy;

            Random random = new Random();
            _tablica = new int[_rozmiarTablicy];

            for (int i = 0; i < _rozmiarTablicy; i++)
                _tablica[i] = random.Next(1, 101);
        }

        public void WyswietlElementy()
        {
            for (int i = 0; i < _rozmiarTablicy; i++)
                Console.WriteLine($"{i}: {_tablica[i]}");
        }

        /***********************************************
            nazwa metody: IndeksPierwszego
            opis metody: Szuka liniowo podanej wartości w tablicy wewnętrznej i zwraca jego indeks lub -1 jeżeli nie ma takiej wartości.
            parametry: int szukanaWartosc - szukana wartość w tablicy.
            zwracany typ i opis: int - indeks elementu lub -1 jeżeli go nie ma w tablicy.
            autor: 00000000000
         ************************************************/
        public int IndeksPierwszego(int szukanaWartosc)
        {
            for (int i = 0; i < _rozmiarTablicy; i++)
                if (_tablica[i] == szukanaWartosc) return i;
            return -1;
        }

        public int SumaNieparzystych()
        {
            int ile = 0;
            for (int i = 0; i < _rozmiarTablicy; i++)
                if (_tablica[i] % 2 != 0)
                {
                    ile++;
                    Console.WriteLine(_tablica[i]);
                }

            return ile;
        }

        public float SredniaArytmetyczna()
        {
            int suma = 0;
            for (int i = 0; i < _rozmiarTablicy; i++)
                suma += _tablica[i];

            return suma / _rozmiarTablicy;
        }
    }
}
