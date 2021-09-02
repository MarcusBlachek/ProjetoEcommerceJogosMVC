using EcommerceJogosEntities;
using Microsoft.EntityFrameworkCore;
using ProjetoGamesEcommerce.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoGamesEcommerce.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EcommerceJogosContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Jogo> jogos)
        {
            foreach (var jogo in jogos)
            {
                if (!dbSet.Where(p => p.Codigo == jogo.Codigo).Any())
                {
                    dbSet.Add(new Produto(jogo.Codigo, jogo.Nome, jogo.Preco));
                }
            }

            contexto.SaveChanges();
        }
    }
    public class Jogo
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
