﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using UserControls;

namespace Trigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            //Setzen des DataContext
            this.DataContext= this;
        }

        public bool BoolVal { get; set; } = false;

        public event PropertyChangedEventHandler? PropertyChanged;

        //EventHandler zum Ändern der Property
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoolVal = !BoolVal;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BoolVal)));   
        }

        //EventHandler des UserControls (vgl. M11_UserControls)
        private void colorpicker_PickedColorChanged(object sender, RoutedPropertyChangedEventArgs<SolidColorBrush> e)
        {
            if ((sender as ColorPicker).PickedColor.ToString().Equals("#FF000000"))
                MessageBox.Show("Alles ist schwarz");
        }
    }
}
