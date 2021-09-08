using System.ComponentModel.DataAnnotations;

namespace ProjetoGamesEcommerce.Models

{
    public class ItemPedido : BaseModel
    {
        [Required]
        public double PrecoUnitario { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public Pedido Pedido { get; set; }
        [Required]
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
