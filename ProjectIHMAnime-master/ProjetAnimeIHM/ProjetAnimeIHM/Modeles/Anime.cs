using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAnimeIHM 
{
  
    public class Anime : NotifyPropertyChangedBase
    {
        public String Titre { get; set; }
        public String Image { get; set; }
        public int Annee { get; set; }
        public String Auteurs { get; set; }
        public String Studios { get; set; }
        public List<Genres> Genres { get; set; }
        public String Synopsis { get; set; }
        public string GenresAnime
        {
            get
            {
                string retour = string.Empty;

                if (Genres != null)
                {
                    foreach (var parcours in Genres)
                    {
                        retour += parcours + " ";
                    }
                }
                return retour;
            }
        }
        public override string ToString()
        {
            return Titre.ToString();
        }
    }
}