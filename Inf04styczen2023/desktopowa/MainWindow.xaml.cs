using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static string MaleLitery = "qwertyuiopasdfghjklzxcvbnm";
        private static string DuzeLitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private static string Cyfry = "1234567890";
        private static string ZnakiSpecjalne = "!@#$%^&*()_+-=";

        private string WygenerowaneHaslo = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbIleZnakow_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pierwotnyCiag = TbIleZnakow.Text;
            if (!int.TryParse(pierwotnyCiag, out int result))
            {
                TbIleZnakow.Text = pierwotnyCiag.Length > 0 || result < 0 ? pierwotnyCiag.Remove(pierwotnyCiag.Length - 1) : "0";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool czyLitery = ChbLitery.IsChecked ?? false;
            bool czyCyfry = ChbCyfry.IsChecked ?? false;
            bool czyZnakiSpecjalne = ChbZSpec.IsChecked ?? false;

            int.TryParse(TbIleZnakow.Text, out int dlugoscHasla);

            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dlugoscHasla; i++)
            {
                int jakaTablica = random.Next(0, 4);

                if (jakaTablica == 0)
                    sb.Append(MaleLitery[random.Next(0, MaleLitery.Length)]);
                else if (jakaTablica == 1 && czyLitery)
                    sb.Append(DuzeLitery[random.Next(0, DuzeLitery.Length)]);
                else if (jakaTablica == 2 && czyCyfry)
                    sb.Append(Cyfry[random.Next(0, Cyfry.Length)]);
                else if (jakaTablica == 3 && czyZnakiSpecjalne)
                    sb.Append(ZnakiSpecjalne[random.Next(0, ZnakiSpecjalne.Length)]);
                else
                {
                    i--;
                    continue;
                }

            }

            WygenerowaneHaslo = sb.ToString();

            MessageBox.Show(WygenerowaneHaslo);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {TbImie.Text} {TbNazwisko.Text} {CbStanowisko.Text} Hasło: {WygenerowaneHaslo}");
        }
    }
}