using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGamesEcommerce.Models;

namespace ProjetoGamesEcommerce
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(T => T.Id);

            builder.Property("Nome")
                .HasColumnType("varchar(70)")
                .IsRequired();
            
            builder.Property("Codigo")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property("Preco")
                .IsRequired();

        }
    }
}