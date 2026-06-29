namespace wspodzielone;

public class Kosc
{
    public static int Instancje = 0;

    public string[] Obrazy = [
        "kosc0.png",
        "kosc1.png",
        "kosc2.png",
        "kosc3.png",
        "kosc4.png",
        "kosc5.png",
        "kosc6.png"
        ];

    public int WyrzuconaWartosc;
    public int ObrazIndeks;
    public bool CzyDostepna;

    public Kosc(int wyrzuconaWartosc)
    {
        if (wyrzuconaWartosc < 0 || wyrzuconaWartosc > 6) wyrzuconaWartosc = 0;
        WyrzuconaWartosc = wyrzuconaWartosc;
        ObrazIndeks = wyrzuconaWartosc;
        CzyDostepna = true;
        Instancje++;
    }

    public Kosc()
    { 
        CzyDostepna = true;
        Rzut();
        Instancje++;
    }

    public void Rzut()
    {
        if (!CzyDostepna) return;
        Random random = new Random();
        int wylosowana = random.Next(1, 6);
        WyrzuconaWartosc = wylosowana;
        ObrazIndeks = wylosowana;
    }

    public void BlokujKosc()
    {
        CzyDostepna = false;
    }

    public string WartoscSlownie()
    {
        return WyrzuconaWartosc switch
        {

            1 => "jeden",
            2 => "dwa",
            3 => "trzy",
            4 => "cztery",
            5 => "pięć",
            6 => "sześć",
            _ => "nie zdefiniowano",
        };
    }
}

