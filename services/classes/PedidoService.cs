
using System.Transactions;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IItemPedidoRepository _itemPedidoRepository;
    private readonly IConvertDtoToModel _convertDtoToModel;
    private readonly AppDbContext _context;
    public PedidoService(IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository,IConvertDtoToModel convertDtoToModel, AppDbContext context )
    {
        _pedidoRepository = pedidoRepository;
        _itemPedidoRepository = itemPedidoRepository;
        _convertDtoToModel = convertDtoToModel;
        _context = context;
    }

    public async Task<Object> create(PedidoDto pedidoDto)
    {
        var pedidoModel = _convertDtoToModel.convertOrder(pedidoDto);
        using(var transaction = await _context.Database.BeginTransactionAsync()){
            try
            {
                var newOrder = await _pedidoRepository.create(pedidoModel);
                Console.WriteLine(newOrder.id);
                foreach (var item in pedidoDto.itemPedidos)
                {
                    var itemPedidoModel = _convertDtoToModel.convertItemOrder(item,newOrder.id);
                    var newItemOrder = await _itemPedidoRepository.create(itemPedidoModel);
                }
                await transaction.CommitAsync();
                var response = new {
                    msg = "pedido realizado com sucesso",
                    status = 200
                };
                return response;
            }
            catch (System.Exception)
            {
                Console.WriteLine("deu rollback");
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}