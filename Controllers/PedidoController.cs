using EcommerceJogosEntities;
using Microsoft.AspNetCore.Mvc;
using ProjetoGamesEcommerce.Repositories;

namespace ProjetoGamesEcommerce.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
        {
            this._produtoRepository = produtoRepository;
            this._pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(_produtoRepository.GetProdutos());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            Pedido pedido = _pedidoRepository.GetPedido();
            return View(pedido.Items);
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
