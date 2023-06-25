using Domain;
using Infra.Interfaces;

namespace Infra
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPorId(int id)
        {
            // lógica para obter o pedido do banco de dados
            throw new NotImplementedException();
        }

        public void Salvar(Pedido pedido)
        {
            // lógica para salvar o pedido no banco de dados
            throw new NotImplementedException();
        }

        // lógica para salvar o pedido no banco de dados
    }
}