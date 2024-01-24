
public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PedidoModel> create(PedidoModel pedidoModel)
    {
        var newPedido = await _context.pedidos.AddAsync(pedidoModel);
        await _context.SaveChangesAsync();
        return pedidoModel;
    }
}