using MediatR;
using System;

namespace Mediator.Request
{
    public class CadastrarClienteRequest : IRequest<string>
    {
        public int ID { get; private set; }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public DateTime DataNasc { get; private set; }

        public CadastrarClienteRequest(int iD, string nome, string sobrenome, DateTime dataNasc)
        {
            ID = iD;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNasc = dataNasc;
        }
    }
}