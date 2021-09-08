using ProjetoGamesEcommerce.Models;
using System.Collections.Generic;

namespace ProjetoGamesEcommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Jogo> jogos);
        IList<Produto> GetProdutos();
    }
}