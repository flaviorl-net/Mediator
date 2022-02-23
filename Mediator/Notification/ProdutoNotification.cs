using MediatR;

namespace Mediator.Notification
{
    public class ProdutoNotification : INotification
    {
        public int ID { get; private set; }

        public string Descricao { get; private set; }

        public decimal Valor { get; private set; }

        public int QuantidadeEstoque { get; set; }

        public ProdutoNotification(int id, string descricao, decimal valor, int quantidadeEstoque)
        {
            ID = id;
            Descricao = descricao;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}