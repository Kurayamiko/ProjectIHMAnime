using Microsoft.Win32;
using System;
using System.Windows;

namespace ProjetAnimeIHM
{
    /// <summary>
    /// Logique d'interaction pour Modifier.xaml
    /// </summary>
    public partial class Modifier : Window
    {

        public Modifier()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }


    }
}
