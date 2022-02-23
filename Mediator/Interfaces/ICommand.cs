using MediatR;

namespace Mediator.Interfaces
{
    public interface ICommand<out T> : IRequest<T>
    {
    }
}