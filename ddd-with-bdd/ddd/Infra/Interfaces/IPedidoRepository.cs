using Domain;

namespace Infra.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido ObterPorId(int id);
        void Salvar(Pedido pedido);
        // outros métodos relevantes
    }
}
