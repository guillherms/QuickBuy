using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(d => d.DataPedido)
                .IsRequired();

            builder
                .Property(d => d.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(d => d.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(d => d.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(d => d.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(d => d.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(d => d.NumeroEndeco)
                .IsRequired();


        }
    }
}
