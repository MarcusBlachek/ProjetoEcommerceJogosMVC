using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");

            builder.HasKey(T => T.Id);

            builder.HasMany(i => i.Items).WithOne(i => i.Pedido);

            builder.HasOne(c => c.Cadastro).WithMany(c => c.Pedidos);
        }
    }
}

