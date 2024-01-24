public class ConvertDtoToModel : IConvertDtoToModel
{
    public PedidoModel convertOrder(PedidoDto pedidoDto)
    {
        PedidoModel pedidoModel = new PedidoModel();
        return pedidoModel;
        
    }
    public ItemPedidoModel convertItemOrder(ItemPedidoDto itemPedidoDto, int idPedido){
        ItemPedidoModel itemPedidoModel = new ItemPedidoModel();
        itemPedidoModel.name = itemPedidoDto.name;
        itemPedidoModel.idPedido = idPedido;
        return itemPedidoModel;
    }

}