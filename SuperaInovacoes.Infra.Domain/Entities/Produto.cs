using System;
using System.Collections.Generic;
using System.Text;

namespace SuperaInovacoes.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public string Imagem { get; private set; }

        public Produto() {}

        public Produto(string nome, decimal valor, string imagem)
        {
            Nome = nome;
            Valor = valor;
            Imagem = imagem;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarValor(decimal valor)
        {
            Valor = valor;
        }

        public void AlterarImagem(string imagem)
        {
            Imagem = imagem;
        }

    }
}
