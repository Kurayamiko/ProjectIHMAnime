using System.Windows;

namespace ProjetAnimeIHM
{
    /// <summary>
    /// Logique d'interaction pour Ajouter.xaml
    /// </summary>
    public partial class Ajouter : Window
    {
        public Anime nAnime;
        public Ajouter()
        {
            InitializeComponent();
            nAnime = new Anime();
            DataContext = nAnime;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (Titre.Text == null || Titre.Text == "")
            {

                MessageBox.Show("Le champ titre est vide");
            }
            else DialogResult = true;
        }



    }
}
