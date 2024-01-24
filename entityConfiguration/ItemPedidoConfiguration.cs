using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedidoModel>
{
    public void Configure(EntityTypeBuilder<ItemPedidoModel> builder)
    {
        builder.HasKey(ip => ip.id);
        builder.HasOne(ip => ip.pedido)
        .WithMany(p => p.itensPedido)
        .HasForeignKey(ip => ip.idPedido);
    }
}