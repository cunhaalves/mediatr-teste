using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebMediatRTeste.Domain.Entity
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
            notification = new DomainNotification();
        }
        public Guid Id { get; set; }
        public DomainNotification notification { get; set; }
        public abstract bool EstaInvalido();
    }
}
