using Domain;
using Infra.Interfaces;

namespace Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public Pedido ObterPedidoPorId(int id)
        {
            return _pedidoRepository.ObterPorId(id);
        }

        public void SalvarPedido(Pedido pedido)
        {
            // Aplicar regras de negócio, validações, etc.
            _pedidoRepository.Salvar(pedido);
        }

        // outros métodos relevantes
    }
}
