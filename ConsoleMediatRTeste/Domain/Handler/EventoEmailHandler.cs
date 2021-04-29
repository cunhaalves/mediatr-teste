using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRTeste.Domain
{
    public class EventoEmailHandler : INotificationHandler<EnviarEmailEvent>
    {
        public async Task Handle(EnviarEmailEvent notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                Console.WriteLine("E-mail enviado");
            });
        }
    }
}
