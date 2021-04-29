using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRTeste.Domain
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

            if (!cliente.EstaValido())
                return cliente.notification;

            Console.WriteLine("Cliente inserido");

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
