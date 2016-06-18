using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ListAnime
    {
        public static List<AnimeEntities> GetAllAnime()
        {
            return new List<AnimeEntities>()
            {
                new AnimeEntities
                {
                    Titre=".Hack//Legend of Twilight", Image="Images/Hack_LegendOfTwilight.jpg", Annee= 2002, Auteurs="Hamazaki Tatsuya, Izumi Rei, Project.hack", Studios="Bee Train Production, Bandai Visual", Genres=new List<Genres> { Genres.Aventure,Genres.Action }, Synopsis="L’histoire tourne autour d’un jeu en réseau appelé The World. CyberConnect Corporation (CC Corporation), le créateur du jeu, a mis en place une campagne pour les joueurs. Le prix de cette campagne est le personnage édition limitée : les légendaires Kite et Black Rose des données « .hackers » qui ont été interdites depuis l’incident Twilight. Deux jumeaux (un garçon et une fille), Shuugo (le plus âgé), et Rena, ont réussi à obtenir les légendaires personnages. Shuugo qui voulait arrêter de jouer, se retrouva une fois de plus dans le jeu avec sa soeur. Ordre chronologique des différents animes du Projet .Hack., du plus ancien au plus récent : Sign / Liminality / Legend of Twilight / Roots / Quantum / Terminal Disk / Sekai no Mukou ni."
                },

                new AnimeEntities
                {
                    Titre="Test", Image="", Annee= 2016
                }
            };
        }
    }
}
