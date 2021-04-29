using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MediatRTeste.Domain.Entity
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DomainNotification notification { get; set; }
        public abstract bool EstaValido();
    }
}
