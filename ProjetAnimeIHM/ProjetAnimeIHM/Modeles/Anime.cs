using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAnimeIHM 
{
    public enum Genres
    {
        Action,
        AmourEtAmitie,
        Aventure,
        CombatsEtArtsMartiaux,
        Comedie,
        ContesEtRecits,
        CyberEtMecha,
        Drame,
        Ecchi,
        EnigmeEtPolicier,
        Fantastique,
        Historique,
        Horreur,
        MagicalGirl,
        Musique,
        Romance,
        ScienceFiction,
        Sport,
        Yaoi,
        Yuri,
    }

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