using ProjetoGamesEcommerce.Data;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce.Repositories
{
    public interface ICadastroRepository
    {
    }
    public class CadastroRepository : BaseRepository<Cadastro>,ICadastroRepository
    {
       
        public CadastroRepository(EcommerceJogosContext contexto) : base(contexto)
        {
        }
    }
}
