using System;
using System.Collections.Generic;
using System.Text;

namespace WebMediatRTeste.Domain
{
    public class DomainNotification
    {
        public static DomainNotification Ok = new DomainNotification();
        public bool HasValidation => _validations.Count > 0;
        private List<string> _validations = new List<string>();
        public IList<string> Validations => _validations;
        public DomainNotification() { }
        public void AddValidation(string validation)
            => _validations.Add(validation);
    }

    public class DomainNotification<TResponse> : DomainNotification
    {
        public TResponse Data { get; private set; }
        public DomainNotification() { }

        public DomainNotification(TResponse data)
        {
            Data = data;
        }
    }
}
