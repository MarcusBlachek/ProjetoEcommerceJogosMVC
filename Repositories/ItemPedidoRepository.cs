using ProjetoGamesEcommerce.Data;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce.Repositories
{
    public interface IItemPedidoRepository
    {
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>,IItemPedidoRepository
    {
        public ItemPedidoRepository(EcommerceJogosContext contexto) : base(contexto)
        {
        }
    }
}
