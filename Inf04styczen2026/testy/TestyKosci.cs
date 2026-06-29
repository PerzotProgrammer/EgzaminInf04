using wspodzielone;

namespace testy
{
    public class TestyKosci
    {

        [Test]
        public void Czy_Wartosc_Kosci_Prawidlowa()
        {
            for(int i = 0; i < 10; i++)
            {
                Kosc kosc = new Kosc();
                Assert.That(kosc.WyrzuconaWartosc > 1 && kosc.WyrzuconaWartosc < 7);
            }
        
        }

        [Test]
        public void Czy_Wartosc_Bez_Zmian_Po_Blokadzie()
        {
            for (int i = 0; i < 10; i++)
            {
                Kosc kosc = new Kosc();
                int stara = kosc.WyrzuconaWartosc;
                kosc.CzyDostepna = false;
                kosc.Rzut();
                Assert.That(kosc.WyrzuconaWartosc == stara);
            }

        }
    }
}
