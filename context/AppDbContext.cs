using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<PedidoModel> pedidos { get; set; }
    public DbSet<ItemPedidoModel> itemPedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}