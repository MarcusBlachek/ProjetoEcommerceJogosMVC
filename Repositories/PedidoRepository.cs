using EcommerceJogosEntities;
using ProjetoGamesEcommerce.Data;

namespace ProjetoGamesEcommerce.Repositories
{
    public interface IPedidoRepository
    {
    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(EcommerceJogosContext contexto) : base(contexto)
        {
        }
    }
}
