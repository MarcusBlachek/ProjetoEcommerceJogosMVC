using Microsoft.EntityFrameworkCore;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce.Data
{
    public class EcommerceJogosContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }
        public EcommerceJogosContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}
