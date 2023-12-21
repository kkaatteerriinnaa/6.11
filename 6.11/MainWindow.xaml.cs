using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _6._11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AlphaSlider.ValueChanged += Slider_ValueChanged;
            RedSlider.ValueChanged += Slider_ValueChanged;
            GreenSlider.ValueChanged += Slider_ValueChanged;
            BlueSlider.ValueChanged += Slider_ValueChanged;

            Button button = (Button)this.FindName("Add");
            button.Click += Button_Click;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromArgb((byte)AlphaSlider.Value, (byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            this.Background = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Color color = ((SolidColorBrush)this.Background).Color;
            string colorString = $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";
            ListBox listBox = (ListBox)this.FindName("ListBox");
            listBox.Items.Add(colorString);
        }
    }
}
