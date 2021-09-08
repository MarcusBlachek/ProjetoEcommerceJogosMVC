using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjetoGamesEcommerce.Data;
using ProjetoGamesEcommerce.Models;
using System;
using System.Linq;

namespace ProjetoGamesEcommerce.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public PedidoRepository(EcommerceJogosContext contexto, IHttpContextAccessor contextAccessor) : base(contexto)
        {
           _contextAccessor = contextAccessor;
        }

        public void AddItem(string codigo)
        {
            var produto = _contexto.Set<Produto>()
                        .Where(p => p.Codigo == codigo)
                        .SingleOrDefault();

            if (produto == null)
            {
                throw new ArgumentException("Produto não encontrado");
            }

            var pedido = GetPedido();

            var itemPedido = _contexto.Set<ItemPedido>()
                                .Where(i => i.Produto.Codigo == codigo
                                 && i.Pedido.Id == pedido.Id)
                                .SingleOrDefault();

            if (itemPedido == null)
            {
                itemPedido = new ItemPedido(produto.Preco, 1, pedido, produto);
                _contexto.Set<ItemPedido>()
                                .Add(itemPedido);

                _contexto.SaveChanges();
            }
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet
                .Include(p => p.Items)
                .ThenInclude(i => i.Produto)
                .Where(p => p.Id == pedidoId)
                .SingleOrDefault();

            if (pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                _contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }

            return pedido;
        }

        private int? GetPedidoId()
        {
            return _contextAccessor.HttpContext.Session.GetInt32("PedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            _contextAccessor.HttpContext.Session.SetInt32("PedidoId", pedidoId);
        }
    }
}
