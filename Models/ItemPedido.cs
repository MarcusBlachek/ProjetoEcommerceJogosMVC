namespace EcommerceJogosEntities
{
    public class ItemPedido : BaseModel
    {
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {
        }
        public ItemPedido(double precoUnitario, int quantidade, Pedido pedido, Produto produto)
        {
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Pedido = pedido;
            Produto = produto;
        }
    }
}
