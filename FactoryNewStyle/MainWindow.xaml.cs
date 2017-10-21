using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryNewStyle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Style = (Style)FindResource(typeof(Window));
            DT.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FontSize = 12;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FontSize = 14;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FontSize = 16;
        }

        private void TextBox_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void TextBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
