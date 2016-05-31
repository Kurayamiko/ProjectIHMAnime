using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace ProjetAnimeIHM
{
    /// <summary>
    /// Logique d'interaction pour Ajouter.xaml
    /// </summary>
    public partial class Ajouter : Window
    {
        public Anime nAnime;
        public String filename;
        
        public Ajouter()
        {
            InitializeComponent();
            nAnime = new Anime();
            DataContext = nAnime;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {

        }
        
       private void Parcourir_Click(object sender, RoutedEventArgs e)
       {
               // Configure open file dialog box
               OpenFileDialog fenetre = new OpenFileDialog();
               string s = "C:\\Users\\" + Environment.UserName + "\\Desktop";
               fenetre.InitialDirectory = s;
               fenetre.Title = "Choisissez votre image"; // Default file name
               fenetre.DefaultExt = ".jpg|.png|.gif|.jpeg";
               fenetre.Filter = "Fichier image|*.jpg;*.png;*.pnj;*.jpeg;*.JPEG"; // Filter files by extension 

               // Show open file dialog box
               bool? result = fenetre.ShowDialog();

               // Process open file dialog box results 
               if (result == true)
               {
                   // Open document 
                   filename = fenetre.FileName;
                   //  Moi.Text = filename;
                   // Imagese.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));

               }

           }

       }
    }
