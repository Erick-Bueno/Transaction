using System.ComponentModel.DataAnnotations.Schema;

public class PedidoModel
{
    public int id { get; private set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid externalId {get; private set;} = Guid.NewGuid();
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime created_at {get; private set;}
    public List<ItemPedidoModel> itensPedido { get; private set; }
    
}