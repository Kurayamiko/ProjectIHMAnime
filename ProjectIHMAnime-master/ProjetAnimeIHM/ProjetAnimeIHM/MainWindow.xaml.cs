using BusinessLayer.Entities;
using ProjetAnimeIHM.ViewModels;
using System.Windows;


namespace ProjetAnimeIHM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListAnimeViewModel _viewmodel;

        public MainWindow()
        {
            InitializeComponent();
            _viewmodel = new ListAnimeViewModel();
            DataContext = _viewmodel;
            
        }


    }
}
