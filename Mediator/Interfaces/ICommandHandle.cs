using MediatR;

namespace Mediator.Interfaces
{
    public interface ICommandHandle<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> 
        where TRequest : ICommand<TResponse>
    {
    }
}
