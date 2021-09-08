using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("itempedidos");

            builder.HasKey(T => T.Id);

            builder.Property("PrecoUnitario")
                .IsRequired();

            builder.Property("Quantidade")
                .IsRequired();

            builder.HasOne(p => p.Pedido).WithMany(p => p.Items);

            builder.HasOne(p => p.Produto);
        }
    }
}

