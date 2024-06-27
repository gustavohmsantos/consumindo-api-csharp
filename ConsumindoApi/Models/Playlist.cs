using System.Text.Json;

namespace ConsumindoApi.Models
{
    internal class Playlist
    {

        public string Nome { get; set; }
        public List<Musica> Musicas { get; }

        public Playlist(string nome)
        {
            Nome = nome;
            Musicas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void ExibirMusicasPlaylist()
        {
            foreach (var musica in Musicas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
        }

        public void ExportarPlaylistEmJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = Musicas
            });
            string nomeDoArquivo = $"playlist-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine(Path.GetFullPath(nomeDoArquivo));
        }
        
    }
}
