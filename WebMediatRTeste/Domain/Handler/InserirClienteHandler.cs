using MediatR;
using MediatRTeste.Domain.Command;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using WebMediatRTeste.Domain.Entity;
using WebMediatRTeste.Domain.Event;

namespace WebMediatRTeste.Domain.Handler
{
    public class InserirClienteHandler : IRequestHandler<InserirClienteCommand, DomainNotification>
    {
        private readonly IMediator _mediator;

        public InserirClienteHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<DomainNotification> Handle(InserirClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente(request.Nome, request.Email);

            if (cliente.EstaInvalido())
                return cliente.notification;

            Debug.WriteLine("Cliente inserido");

            await _mediator.Publish(new EnviarEmailEvent
            {
                Nome = request.Nome,
                Email = request.Email
            },
            cancellationToken);

            return DomainNotification.Ok;
        }
    }
}
