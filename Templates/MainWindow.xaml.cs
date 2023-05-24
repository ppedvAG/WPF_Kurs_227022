using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button funktioniert");

        }

        public ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>()
        {
            new Person() {Vorname="Anna", Nachname="Nass", Alter=34},
            new Person() {Vorname="Rainer", Nachname="Zufall", Alter=67 },
            new Chef(){Vorname="Hannes", Nachname="Maier", Alter=87, Gehalt=6000}
        };

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            Personenliste.Remove((sender as Button).Tag as Person);
        }
    }
}
