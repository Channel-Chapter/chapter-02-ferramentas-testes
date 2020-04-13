namespace FerramentasTesteUnidade.Tests
{
    public class PedidoRepository
    {
        public IPedidoRepositoryService Service { get; set; }

        public PedidoRepository(IPedidoRepositoryService service)
        {
            this.Service = service;
        }

        public Pedido BuscarPedido(int id)
        {
            return this.Service.Find(id);
        }
    }
}