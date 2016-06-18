using BusinessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetAnimeIHM.Factory
{
    public static class AnimeFactory
    {
        public static Anime AnimeEntitiesToAnimeModele(AnimeEntities anime)
        {
            return new Anime
            {
                Titre = anime.Titre,
                Image = anime.Image,
                Annee = anime.Annee,
                Auteurs = anime.Auteurs,
                Studios = anime.Studios,
                Genres = anime.Genres,
                Synopsis = anime.Synopsis,
            };
        }

        public static List<Anime> AllAnimeEntitiesToAnime(List<AnimeEntities> list)
        {
            return list.Select(AnimeEntitiesToAnimeModele).ToList();
        }
    }
}
