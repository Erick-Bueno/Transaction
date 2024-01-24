public interface IConvertDtoToModel
{
    public PedidoModel convertOrder(PedidoDto pedidoDto);
    public ItemPedidoModel convertItemOrder(ItemPedidoDto itemPedidoDto,int idPedido);
}