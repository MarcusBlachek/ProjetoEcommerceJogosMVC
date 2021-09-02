using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoGamesEcommerce
{
    public class CadastroConfiguration : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.ToTable("cadastros");

            builder.Property("Bairro")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property("Endereco")
                .IsRequired();

            builder.Property("Cep")
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.Property("Complemento")
                .HasColumnType("varchar(25)");

            builder.Property("Nome")
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property("Email")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property("Municipio")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property("Uf")
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property("Telefone")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.HasMany(p => p.Pedidos).WithOne(p => p.Cadastro);
        }
    }
}

