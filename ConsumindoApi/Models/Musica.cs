﻿using System.Text.Json.Serialization;

namespace ConsumindoApi.Models
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string[] tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

        public string Tonalidade
        {
            get
            {
                return tonalidades[Key];
            }
        }
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {Artista}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}
