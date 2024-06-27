using ConsumindoApi.Models;

namespace ConsumindoApi.Filters
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musica => musica.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Equals(genero))
                .Select(musica => musica.Artista).Distinct().ToList();

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(nomeDoArtista)).ToList();

            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        public static void FiltrarMusicasPorTonalidadeCSharp(List<Musica> musicas)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Key == 1)
                .Select(musica => musica.Nome).ToList();

            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
