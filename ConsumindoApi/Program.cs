using ConsumindoApi.Filters;
using ConsumindoApi.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        musicas[0].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarMusicasPorTonalidadeCSharp(musicas);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenada(musicas);



        //Playlist playlist1 = new Playlist("PrimeiraPlaylist");

        //playlist1.AdicionarMusica(musicas[4]);
        //playlist1.AdicionarMusica(musicas[28]);
        //playlist1.AdicionarMusica(musicas[395]);
        //playlist1.AdicionarMusica(musicas[492]);
        //playlist1.AdicionarMusica(musicas[588]);

        //playlist1.ExibirMusicasPlaylist();

        //playlist1.ExportarPlaylistEmJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}