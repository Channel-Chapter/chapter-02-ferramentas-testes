using Xunit;

namespace FerramentasTesteUnidade.Tests
{
    public class PedidoTest
    {
        [Fact]
        public void BuscarPedidos_Com_Valores()
        {
            /// utilizando um reposit�rio (mock)
            /// sem precisar utilizar o banco de dados de produ��o

            //arrange
            PedidoRepository repository = new PedidoRepository(new MockPedidoRepositoryService());

            //act
            Pedido pedido = repository.BuscarPedido(2);

            // testes unit�rios
            //assert
            Assert.NotNull(pedido); ///o pedido 2 foi localizado
            Assert.Equal(2, pedido.Id); ///"O pedido 2 n�o est� com as propriedades corretas (Id)"
            Assert.NotEqual(0d, pedido.Valor);/// "O pedido tem pre�o igual � 0"
        }

        [Fact]
        public void BuscarPedidos_Nao_Encontrado()
        {
            /// utilizando um reposit�rio (mock)
            /// sem precisar utilizar o banco de dados de produ��o

            //arrange
            PedidoRepository repository = new PedidoRepository(new MockPedidoRepositoryService());

            //act
            Pedido pedido = repository.BuscarPedido(1);

            //assert
            Assert.Null(pedido); ///"O pedido 1 n�o foi localizado"
        }
    }
}