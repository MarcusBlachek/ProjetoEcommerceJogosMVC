﻿using System.Collections.Generic;

namespace EcommerceJogosEntities
{
    public class Produto : BaseModel
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public IList<ItemPedido> Items { get; set; }

        public Produto()
        {
        }
        public Produto(string codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}
