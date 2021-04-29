using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebMediatRTeste.Domain;

namespace MediatRTeste.Domain.Command
{
    public class InserirClienteCommand: IRequest<DomainNotification>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
