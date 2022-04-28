using Observr;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverConsole
{
    public class Acao
    {
        private readonly IBroker _eventBroker;
        private decimal _valor;

        public string Codigo { get; set; }

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                _eventBroker.Publish<Acao>(this);
            }
        }

        public Acao(IBroker eventBroker)
        {
            _eventBroker = eventBroker;
        }
    }
}
