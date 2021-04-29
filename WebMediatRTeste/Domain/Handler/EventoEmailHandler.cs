using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMediatRTeste.Domain.Event;

namespace WebMediatRTeste.Domain.Handler
{
    public class EventoEmailHandler : INotificationHandler<EnviarEmailEvent>
    {
        public async Task Handle(EnviarEmailEvent notification, CancellationToken cancellationToken)
        {
            await Task.Run(() => {
                Debug.WriteLine("E-mail enviado");
            });
        }
    }
}
