using System.Collections.Generic;

namespace EcommerceJogosEntities
{
    public class Pedido : BaseModel
    {
        public Cadastro Cadastro { get; set; }
        public IList<ItemPedido> Items { get; set; }

        public Pedido()
        {
        }
        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }
    }
}
