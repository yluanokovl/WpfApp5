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

namespace WpfApp2
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
        private void MSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = (sender as System.Windows.Controls.Slider);
            double slValue = slider.Value;

            InkAttr.Height = slValue;
            InkAttr.Width = slValue;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            var cbItem = (sender as System.Windows.Controls.ComboBoxItem);
            string cbName = cbItem.Content.ToString();

            if (cbName == "Red") InkAttr.Color = Color.FromRgb(255, 0, 0);
            else if (cbName == "Green") InkAttr.Color = Color.FromRgb(0, 255, 0);
            else if (cbName == "Blue") InkAttr.Color = Color.FromRgb(0, 0, 255);
        }

        private void rbDraw_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void rbEdit_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.Select;
        }

        private void rbDelete_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }
}