using Newtonsoft.Json;
using ProjetoGamesEcommerce.Data;
using ProjetoGamesEcommerce.Repositories;
using System.Collections.Generic;
using System.IO;

namespace ProjetoGamesEcommerce
{
    class DataService : IDataService
    {
        private readonly EcommerceJogosContext contexto;
        private readonly IProdutoRepository produtoRepository;


        public DataService(EcommerceJogosContext contexto,IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.contexto = contexto;
        }
        
        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
            List<Jogo> jogos = GetJogos();
            produtoRepository.SaveProdutos(jogos);
        }

        private static List<Jogo> GetJogos()
        {
            var json = File.ReadAllText("jogos.json");
            var jogos = JsonConvert.DeserializeObject<List<Jogo>>(json);
            return jogos;
        }
    }

    
}
