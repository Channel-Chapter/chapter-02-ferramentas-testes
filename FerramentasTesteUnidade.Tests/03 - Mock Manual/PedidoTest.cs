using Xunit;

namespace FerramentasTesteUnidade.Tests
{
    public class PedidoTest
    {
        [Fact]
        public void BuscarPedidos_Com_Valores()
        {
            /// utilizando um repositório (mock)
            /// sem precisar utilizar o banco de dados de produção

            //arrange
            PedidoRepository repository = new PedidoRepository(new MockPedidoRepositoryService());

            //act
            Pedido pedido = repository.BuscarPedido(2);

            // testes unitários
            //assert
            Assert.NotNull(pedido); ///o pedido 2 foi localizado
            Assert.Equal(2, pedido.Id); ///"O pedido 2 não está com as propriedades corretas (Id)"
            Assert.NotEqual(0d, pedido.Valor);/// "O pedido tem preço igual à 0"
        }

        [Fact]
        public void BuscarPedidos_Nao_Encontrado()
        {
            /// utilizando um repositório (mock)
            /// sem precisar utilizar o banco de dados de produção

            //arrange
            PedidoRepository repository = new PedidoRepository(new MockPedidoRepositoryService());

            //act
            Pedido pedido = repository.BuscarPedido(1);

            //assert
            Assert.Null(pedido); ///"O pedido 1 não foi localizado"
        }
    }
}