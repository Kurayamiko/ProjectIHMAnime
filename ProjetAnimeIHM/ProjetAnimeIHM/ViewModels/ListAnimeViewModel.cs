using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAnimeIHM.ViewModels
{
    public class ListAnimeViewModel : NotifyPropertyChangedBase
        {
            public DelegateCommand OnAddCommand { get; set; }
            public DelegateCommand EditCommand { get; set; }
            private Anime _anime;
            private List<Anime> _listeAnime;

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

            public List<Anime> ListeAnime
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
                ListeAnime = Factory.AnimeFactory.AllAnimeEntitiesToAnime(ListAnime.GetAllAnime());

                OnAddCommand = new DelegateCommand(OnAddAction, CanExecuteAdd);
                EditCommand = new DelegateCommand(OnEditCommand, CanEditCommand);
            }


            private void OnAddAction(object o)
            {
                Ajouter add = new Ajouter();
                add.Name = "Ajout";
                add.ShowDialog();
            }

            private void OnEditCommand(object o)
            {
                Modifier mod = new Modifier();
                mod.Name = "Edit";
                mod.ShowDialog();
            }

            private bool CanExecuteAdd(object o)
            {
                return true;
            }

            private bool CanEditCommand(Object o)
            {
                return Anime != null;
            }

        }
    }
