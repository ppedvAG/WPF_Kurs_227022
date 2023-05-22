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

namespace Grundlagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainFenster : Window
    {
        public MainFenster()
        {
            InitializeComponent();

            Btn_KlickMich.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "Wurde geklickt";

            Btn_KlickMich.Background = new SolidColorBrush(Colors.Green);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Title = (sender as TextBox).Text;
        }
    }
}
