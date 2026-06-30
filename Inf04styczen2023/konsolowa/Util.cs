using System;
using System.Collections.Generic;
using System.Text;

namespace konsolowa;

public static class Util
{
    /*
    **********************************************
    nazwa funkcji: Nwd
    opis funkcji: Oblicza największy wspólny dzielnik z dwóch liczb
    parametry: 
    a - pierwsza liczba (int)
    b - druga liczba (int)
    zwracany typ i opis: zwraca największy wspólny dzielnik z a i b (int)
    autor: 00000000000
    ***********************************************
     */
    public static int Nwd(int a, int b)
    {
        while (a != b)
        {
            if (a > b) a -= b;
            else b -= a;
        }
        return a;
    }
}

