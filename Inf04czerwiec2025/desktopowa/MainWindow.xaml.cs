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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!IsInitialized) return;

            RectColor.Fill = new SolidColorBrush(GetCurrentColor());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!IsInitialized) return;

            Color color = GetCurrentColor();

            PreviewLabel.Background = new SolidColorBrush(color);

            PreviewLabel.Content = $"{color.R},{color.G},{color.B}";
        }

        private Color GetCurrentColor()
        {
            byte red = (byte)SliderR.Value;
            byte green = (byte)SliderG.Value;
            byte blue = (byte)SliderB.Value;

            SliderRLabel.Content = red;
            SliderGLabel.Content = green;
            SliderBLabel.Content = blue;

            return Color.FromArgb(255, red, green, blue);
        }
    }
}