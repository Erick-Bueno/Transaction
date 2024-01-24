
public class ItemPedidoRepository : IItemPedidoRepository
{
    private readonly AppDbContext _context;

    public ItemPedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ItemPedidoModel> create(ItemPedidoModel itemPedidoModel)
    {
    
      var newItemPedido = await _context.itemPedidos.AddAsync(itemPedidoModel);
        await _context.SaveChangesAsync();
        return itemPedidoModel; 
    }
}