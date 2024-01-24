using System.ComponentModel.DataAnnotations.Schema;

public class ItemPedidoModel
{
    public int id { get; private set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid externalId { get; private set; } = Guid.NewGuid();
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string name { get; set; }
    public int idPedido { get; set; }
    public PedidoModel pedido { get; private set; }

}