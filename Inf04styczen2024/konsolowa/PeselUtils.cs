using System;
using System.Collections.Generic;
using System.Text;

namespace konsolowa;

internal static class PeselUtils
{

    /*
     *  nazwa funkcji: CheckPesel
     *  opis funkcji: Sprawdza czy numer PESEL jest prawdziwy i prawidłowy
     *  parametry: pesel - string (ciąg znaków) powinien być o długości równej 11
     *  zwracany typ i opis: zwraca true jeżeli numer prawidłowy, false jeżeli przeciwnie
     *  autor: 55030101193
     */

    public static bool CheckPesel(string pesel = "55030101193")
    {
        char[] chrs = pesel.ToCharArray();
        string[] p = new string[chrs.Length];

        for (int i = 0; i < p.Length; i++) p[i] = chrs[i].ToString();

        if (p.Length != 11) return false;



        foreach (string c in p)
        {
            if (!int.TryParse(c, out _)) return false;
        }

        int s = 0;

        s += int.Parse(p[0]) *1;
        s += int.Parse(p[1]) * 3;
        s += int.Parse(p[2]) * 7;
        s += int.Parse(p[3]) * 9;
        s += int.Parse(p[4]) * 1;
        s += int.Parse(p[5]) * 3;
        s += int.Parse(p[6]) * 7;
        s += int.Parse(p[7]) * 9;
        s += int.Parse(p[8]) * 1;
        s += int.Parse(p[9]) * 3;

        int m = s % 10;
        int r = m == 0 ? 0 : 10 - m;

        if (r != int.Parse(p[10])) return false;

        return true;
    }

    public static char CheckSex(string pesel = "55030101193")
    {
        string[] p = pesel.Split();

        if (p.Length != 11) return 'U';

        if (int.Parse(p[9]) % 2 == 0) return 'K';
        return 'M';
    }
}

