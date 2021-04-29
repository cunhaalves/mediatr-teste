using System;
using System.Collections.Generic;
using System.Text;


namespace WebMediatRTeste.Domain.Entity
{
    public class Cliente: EntityBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override bool EstaInvalido()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                notification.AddValidation("Nome inválido");
            }

            return notification.HasValidation;
        }
    }
}
