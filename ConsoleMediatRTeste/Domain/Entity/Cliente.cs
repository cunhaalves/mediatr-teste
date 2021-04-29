using System;
using System.Collections.Generic;
using System.Text;
using MediatRTeste.Domain.Entity;

namespace MediatRTeste.Domain
{
    public class Cliente: EntityBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public Cliente(string nome, string email)
        {
            Nome = Nome;
            Email = email;
        }
        public override bool EstaValido()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                notification.AddValidation("Nome inválido");
            }

            return notification.HasValidation;
        }
    }
}
