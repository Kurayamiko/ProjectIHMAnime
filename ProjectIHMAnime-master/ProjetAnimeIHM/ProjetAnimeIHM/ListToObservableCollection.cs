using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetAnimeIHM;

namespace Library
{
    public class ListToObservableCollection
    {


        internal static ObservableCollection<Anime> Convert(List<Anime> list)
        {
            ObservableCollection<Anime> tmp = new ObservableCollection<Anime>();
            foreach (Anime i in list)
            {
                tmp.Add(i);
            }
            return tmp;
        }
    }
}