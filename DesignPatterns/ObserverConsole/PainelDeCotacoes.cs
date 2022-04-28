using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverConsole
{
    public class PainelDeCotacoes : Observr.IObserver<Acao>
    {
        public Task Handle(Acao value, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Novo valor da ação {value.Codigo}: {value.Valor}");
            return Task.CompletedTask;
        }
    }
}
