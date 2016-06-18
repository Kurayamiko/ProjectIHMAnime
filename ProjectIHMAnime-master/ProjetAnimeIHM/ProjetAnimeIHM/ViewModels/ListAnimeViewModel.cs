using BusinessLayer;
using BusinessLayer.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace ProjetAnimeIHM.ViewModels
{
    public class ListAnimeViewModel : NotifyPropertyChangedBase
    {
        public DelegateCommand SauvegarderCommand { get; set; }
        public DelegateCommand RechercherCommand { get; set; }
        public DelegateCommand ParcourirCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand OnAddCommand { get; set; }
        public DelegateCommand EditCommand { get; set; }
        private Anime _anime;
        private ObservableCollection<Anime> _listeAnime;
        public String Image;
        public String T1 { get; set; }

        public Anime Anime
        {
            get
            {
                return _anime;
            }
            set
            {
                _anime = value;
                NotifyPropertyChanged("Anime");
                NotifyPropertyChanged("ListeAnime");
                EditCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<Anime> ListeAnimee
        {
            get
            {
                return _listeAnime;
            }
            set
            {
                _listeAnime = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ListAnimeViewModel()
        {
            List<Anime> list = new List<Anime>();

            StreamReader reader = new StreamReader("fichierTexte.txt");
            {
                while (reader.ReadLine() !=null)
                {
                    //list += reader.ReadLine();
                }
            }

            if(list.Capacity == 0)
            {
                ListeAnimee = Library.ListToObservableCollection.Convert(Factory.AnimeFactory.AllAnimeEntitiesToAnime(ListAnime.GetAllAnime()));
            }
            else
            {
                ListeAnimee = Library.ListToObservableCollection.Convert(list);
            }
           

            ParcourirCommand = new DelegateCommand(OnParcourirCommand, CanExecuteAdd);
            OnAddCommand = new DelegateCommand(OnAddAction, CanExecuteAdd);
            EditCommand = new DelegateCommand(OnEditCommand, CanEditCommand);
            DeleteCommand = new DelegateCommand(OnDeleteCommand, CanEditCommand);
            RechercherCommand = new DelegateCommand(OnRechercheCommand, CanExecuteAdd);
            SauvegarderCommand = new DelegateCommand(OnSauvegarderCommand, CanExecuteAdd);


        }


        private void OnAddAction(object o)
        {
            Ajouter add = new Ajouter();
            add.Name = "Ajout";
            if (add.ShowDialog() == true)
            {
                Anime = add.nAnime;
                ListeAnimee.Add(Anime);

            }
        }


        private void OnEditCommand(object o)
        {
            Modifier mod = new Modifier();
            mod.Name = "Edit";
            mod.DataContext = Anime;
            Anime anim = Anime;
            mod.ShowDialog();
            ListeAnimee.Add(Anime);
            ListeAnimee.Remove(anim);

        }

        private void OnDeleteCommand(object o)
        {
            ListeAnimee.Remove(Anime);

        }
        private bool CanExecuteAdd(object o)
        {
            return true;
        }

        private bool CanEditCommand(Object o)
        {
            return Anime != null;
        }

        private void OnRechercheCommand(object o)
        {
            List<Anime> list = new List<Anime>();
            if (String.IsNullOrEmpty(T1.Trim()) == false)
            {
                ListeAnimee = null;
                foreach (Anime str in Factory.AnimeFactory.AllAnimeEntitiesToAnime(ListAnime.GetAllAnime()))
                {
                    if (str.Titre.StartsWith(T1.Trim()))

                    {
                        list.Add(str);
                    }
                }
            }

            else if (T1.Trim() == "")
            {
                ListeAnimee = Library.ListToObservableCollection.Convert(Factory.AnimeFactory.AllAnimeEntitiesToAnime(ListAnime.GetAllAnime()));
            }
            ListeAnimee = Library.ListToObservableCollection.Convert(list);
        }

        private void OnSauvegarderCommand(object o)
        {
           StreamWriter writer = new StreamWriter("fichierTexte.txt") ;
            {
                foreach (Anime anim in ListeAnimee)
                {
                    writer.WriteLine(anim);
                }
                writer.Flush(); // permet de valider l'écriture dans le flux
            }
        }

        private void OnParcourirCommand(object o)
        {
            string filename;
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
                Image = filename;

            }

        }
    }
}
