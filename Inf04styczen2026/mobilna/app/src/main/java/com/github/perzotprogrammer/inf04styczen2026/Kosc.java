package com.github.perzotprogrammer.inf04styczen2026;

import android.graphics.drawable.Drawable;

import java.util.Random;

public class Kosc {
    public static int Instancje = 0;

    public int[] Obrazy = new int[]{
            R.drawable.kosc0,
            R.drawable.kosc1,
            R.drawable.kosc2,
            R.drawable.kosc3,
            R.drawable.kosc4,
            R.drawable.kosc5,
            R.drawable.kosc6,
    };

    public int WyrzuconaWartosc;
    public int ObrazIndeks;
    public boolean CzyDostepna;

    public Kosc(int wyrzuconaWartosc) {
        if (wyrzuconaWartosc < 0 || wyrzuconaWartosc > 6) wyrzuconaWartosc = 0;
        WyrzuconaWartosc = wyrzuconaWartosc;
        ObrazIndeks = wyrzuconaWartosc;
        CzyDostepna = true;
        Instancje++;
    }

    public Kosc() {
        rzut();
        CzyDostepna = true;
        Instancje++;
    }

    public void rzut() {
        Random random = new Random();
        int wylosowana = 1 + (Math.abs(random.nextInt()) % 6);
        WyrzuconaWartosc = wylosowana;
        ObrazIndeks = wylosowana;
    }

    public void blokujKosc() {
        CzyDostepna = false;
    }

    public String wartoscSlownie() {
        switch (WyrzuconaWartosc) {

            case 1:
                return "jeden";
            case 2:
                return "dwa";
            case 3:
                return "trzy";
            case 4:
                return "cztery";
            case 5:
                return "pięć";
            case 6:
                return "sześć";
            default:
                return "nie zdefiniowano";
        }
    }
}