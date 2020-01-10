using System;
using System.Collections.Generic;
using System.Text;
using Desafio04.Models.Interfaces;

namespace Desafio04.Models {
    class VideoGame : Produto, IImposto {

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public bool IsUsado { get; set; }

        public VideoGame() {
        }

        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool isUsado) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public double CalculaImposto() {
            if (IsUsado) {
                return Preco * 0.25;
            } else {
                return Preco * 0.45;
            }
        }

        public override string ToString() {
            return $"Video-Game: {Nome}\n" +
                   $"Preço: {Preco.ToString("C2")}\n" +
                   $"Quantidade em Estoque: {Quantidade}\n";
        }
    }
}
