using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio04.Models {
    class Loja {
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public List<Livro> Livros { get; set; }

        public List<VideoGame> VideoGames { get; set; }

        public Loja() {
        }

        public Loja(string nome, string cNPJ, List<Livro> livros, List<VideoGame> videoGames) {
            Nome = nome;
            CNPJ = cNPJ;
            Livros = livros;
            VideoGames = videoGames;
        }

        public double CalcularPatrimonio() {
            return Livros.Sum(l => l.Quantidade * l.Preco) + VideoGames.Sum(v => v.Quantidade * v.Preco);
        }
    }
}
