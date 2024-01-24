public interface IPedidoRepository
{
    public Task<PedidoModel> create (PedidoModel pedidoModel);
}