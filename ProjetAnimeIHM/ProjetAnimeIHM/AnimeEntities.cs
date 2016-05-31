using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAnimeIHM
{
    public class AnimeEntities
    {
            public String Titre { get; set; }
            public String Image { get; set; }
            public int Annee { get; set; }
            public String Auteurs { get; set; }
            public String Studios { get; set; }
            public Genres Genres { get; set; }
            public String Synopsis { get; set; }
    }
}