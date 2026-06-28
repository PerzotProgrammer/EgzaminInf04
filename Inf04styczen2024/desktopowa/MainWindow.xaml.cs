using System.IO;
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

        private ImageSource LewoDomyslneImg;
        private ImageSource PrawoDomyslneImg;

        public MainWindow()
        {
            InitializeComponent();
            LewoDomyslneImg = ImgLewo.Source.Clone();
            PrawoDomyslneImg = ImgPrawo.Source.Clone();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NumerBox.Text.Length == 0 || ImieBox.Text.Length == 0 || NazwiskoBox.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź dane!");
            }
            else
            {
                string kolorOczu = "";
                if (RBNiebieskie.IsChecked == true)
                    kolorOczu = "niebieskie";
                else if (RBZielone.IsChecked == true)
                    kolorOczu = "zielone";
                else if (RBPiwne.IsChecked == true)
                    kolorOczu = "piwne";

                MessageBox.Show($"{ImieBox.Text} {NazwiskoBox.Text} kolor oczu {kolorOczu}");
            }
        }

        private void NumerBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string zdjecieSrc = $"./img/{NumerBox.Text}-zdjecie.jpg";
            string odciskSrc = $"./img/{NumerBox.Text}-odcisk.jpg";

            if (File.Exists(zdjecieSrc) && File.Exists(odciskSrc))
            {
                ImgLewo.Source = new BitmapImage(new Uri(zdjecieSrc, UriKind.Relative));
                ImgPrawo.Source = new BitmapImage(new Uri(odciskSrc, UriKind.Relative));
            }
            else
            {
                ImgLewo.Source = LewoDomyslneImg;
                ImgPrawo.Source = PrawoDomyslneImg;
            }
        }
    }
}