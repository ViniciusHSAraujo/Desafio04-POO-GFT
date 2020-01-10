using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.Models {
    abstract class Produto {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto() {
        }

        protected Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
