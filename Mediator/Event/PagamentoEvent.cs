namespace Mediator.Event
{
    public class PagamentoEvent : Interfaces.IEvent
    {
        public int Id { get; private set; }

        public int IdPedido { get; private set; }

        public int IdCliente { get; private set; }

        public string Cartao { get; private set; }

        public PagamentoEvent(int id, int idPedido, int idCliente, string cartao)
        {
            Id = id;
            IdPedido = idPedido;
            IdCliente = idCliente;
            Cartao = cartao;
        }
    }
}
