using System.Collections.Generic;

namespace ProjetoGamesEcommerce.Models

{
    public class Pedido : BaseModel
    {
        public Cadastro Cadastro { get; set; }
        public List<ItemPedido> Items { get; set; }=new List<ItemPedido>();

        public Pedido()
        {
        }
        public Pedido(Cadastro cadastro)
        {
           
            Cadastro = cadastro;
        }
    }
}
