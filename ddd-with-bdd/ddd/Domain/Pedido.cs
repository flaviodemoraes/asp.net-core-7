namespace Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
    }
}