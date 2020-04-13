using System.Collections.Generic;
using System.Linq;

namespace FerramentasTesteUnidade.Tests
{
    /// <summary>
    /// classe que simula o SGBD
    /// </summary>
    public class MockPedidoRepositoryService : IPedidoRepositoryService
    {
        private readonly List<Pedido> pedidos;

        public MockPedidoRepositoryService()
        {
            this.pedidos = new List<Pedido>();

            // para os testes é necessário que
            // exista algum dado no banco
            this.pedidos.Add(new Pedido() { Id = 1, Valor = 140.50, Cliente = "Lucas" });
            this.pedidos.Add(new Pedido() { Id = 2, Valor = 95.40, Cliente = "Caroline" });
            this.pedidos.Add(new Pedido() { Id = 3, Valor = 39.99, Cliente = "Bruna" });
        }

        public Pedido Find(int id)
        {
            if (id == 1)
            {
                // simulando uma falha do SGBD ao pesquisar pelo pedido com ID = 1
                return null;
            }
            return this.pedidos
                .FirstOrDefault(x => x.Id == id);
        }
    }
}