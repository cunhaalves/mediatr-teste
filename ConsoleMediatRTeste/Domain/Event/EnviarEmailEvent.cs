using MediatR;
using System;
using System.Collections.Generic;
using System.Text;


namespace MediatRTeste.Domain
{
    public class EnviarEmailEvent: INotification
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
