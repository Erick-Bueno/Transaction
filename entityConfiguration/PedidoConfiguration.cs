using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PedidoConfiguration : IEntityTypeConfiguration<PedidoModel>
{
    public void Configure(EntityTypeBuilder<PedidoModel> builder)
    {
        builder.HasKey(p => p.id);
    }
}