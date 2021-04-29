using MediatR;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebMediatRTeste.Domain.Event
{
    public class EnviarEmailEvent: INotification
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
