using Domain;
using NUnit.Framework;
using Services;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    public class PedidoSteps
    {
        private Pedido _pedido;
        private Pedido _pedidoConsultado;
        private readonly PedidoService _pedidoService;

        public PedidoSteps(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [Given(@"um pedido com o id (\d+) existe no sistema")]
        public void GivenUmPedidoComOIdExisteNoSistema(int id)
        {
            _pedido = new Pedido { Id = id, Cliente = "João", Itens = new List<ItemPedido>() };
            // lógica para salvar o pedido no banco de dados ou em memória
        }

        [When(@"o usuário consulta o pedido com o id (\d+)")]
        public void WhenOUsuarioConsultaOPedidoComOId(int id)
        {
            _pedidoConsultado = _pedidoService.ObterPedidoPorId(id);
        }

        [Then(@"o sistema retorna o pedido com o id (\d+)")]
        public void ThenOSistemaRetornaOPedidoComOId(int id)
        {
            Assert.NotNull(_pedidoConsultado);
            Assert.Equals(id, _pedidoConsultado.Id);
        }

        [Given(@"um novo pedido a ser criado")]
        public void GivenUmNovoPedidoASerCriado()
        {
            _pedido = new Pedido { Cliente = "Maria", Itens = new List<ItemPedido>() };
        }

        [When(@"o usuário salva o pedido")]
        public void WhenOUsuarioSalvaOPedido()
        {
            _pedidoService.SalvarPedido(_pedido);
        }

        [Then(@"o pedido é salvo com sucesso no sistema")]
        public void ThenOPedidoESalvoComSucessoNoSistema()
        {
            // lógica para verificar se o pedido foi salvo corretamente
        }
    }
}