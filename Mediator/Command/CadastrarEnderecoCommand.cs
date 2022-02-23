using Mediator.Interfaces;

namespace Mediator.Command
{
    public class CadastrarEnderecoCommand : ICommand<string>
    {
        public int Id { get; private set; }

        public string Logradouro { get; private set; }

        public string Endereco { get; private set; }

        public int Numero { get; private set; }

        public string Complemento { get; private set; }

        public CadastrarEnderecoCommand(int id, string logradouro, string endereco, int numero, string complemento)
        {
            Id = id;
            Logradouro = logradouro;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
