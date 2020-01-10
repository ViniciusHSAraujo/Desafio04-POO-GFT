using System;
using System.Collections.Generic;
using System.Text;
using Desafio04.Models.Interfaces;

namespace Desafio04.Models {
    class Livro : Produto, IImposto {

        public string Autor { get; set; }

        public string Tema { get; set; }

        public int QuantidadePaginas { get; set; }

        public Livro() {
        }

        public Livro(string nome, double preco, int quantidade, string autor, string tema, int quantidadeDePaginas) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Autor = autor;
            Tema = tema;
            QuantidadePaginas = quantidadeDePaginas;
        }

        public double CalculaImposto() {
            if (Tema.Equals("Educativo", StringComparison.InvariantCultureIgnoreCase)) {
                return 0;
            } else {
                return Preco * 0.1;
            }
        }

        public override string ToString() {
            return $"Titulo: {Nome}\n" +
                   $"Preço: {Preco.ToString("C2")}\n" +
                   $"Quantidade em Estoque: {Quantidade}\n";
        }
    }
}