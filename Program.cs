using Desafio04.Models;
using System;
using static System.Console;
using System.Collections.Generic;

namespace Desafio04 {
    class Program {
        static void Main(string[] args) {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "Fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "Fantasia", 500);
            Livro l3 = new Livro("C# POO", 20, 50, "GFT", "Educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 8, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "33.014.556/0001-96", livros, games);

            WriteLine("----------------------------------------------------------------");
            WriteLine($"Imposto do {l2.Nome}: {l2.CalculaImposto().ToString("C2")}");
            WriteLine($"Imposto do {l3.Nome}: {l3.CalculaImposto().ToString("C2")}");




            WriteLine($"Imposto do PS4 usado: {ps4Usado.CalculaImposto().ToString("C2")}");
            WriteLine($"Imposto do PS4: {ps4.CalculaImposto().ToString("C2")}");

            ListarLivros(americanas);
            ListarVideoGames(americanas);
            CalcularPatrimonioDeUmaLoja(americanas);

        }

        private static void CalcularPatrimonioDeUmaLoja(Loja loja) {
            WriteLine("----------------------------------------------------------------");
            WriteLine($"O patrimônio da loja {loja.Nome} é: {loja.CalcularPatrimonio().ToString("C2")}");
        }

        private static void ListarLivros(Loja loja) {
            WriteLine("----------------------------------------------------------------");
            WriteLine($"A loja {loja.Nome} possui estes livros para a venda:\n");
            foreach (var livro in loja.Livros) {
                WriteLine(livro);
            }
        }

        private static void ListarVideoGames(Loja loja) {
            WriteLine("----------------------------------------------------------------");
            WriteLine($"A loja {loja.Nome} possui estes vídeo-games para a venda:\n");
            foreach (var videoGame in loja.VideoGames) {
                WriteLine(videoGame);
            }
        }
    }
}
