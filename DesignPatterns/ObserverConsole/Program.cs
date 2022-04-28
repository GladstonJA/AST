using Observr;
using System;
using System.Collections.Generic;

namespace ObserverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IBroker broker = new Broker();

            Dictionary<string, Acao> acoes = new Dictionary<string, Acao>();
            var acaoRandon = new Acao(broker) { Codigo = "RAPT4", Valor = 25 };
            var acaoVia = new Acao(broker) { Codigo = "VVAR3", Valor = 10 };
            acoes.Add(acaoRandon.Codigo, acaoRandon);
            acoes.Add(acaoVia.Codigo, acaoVia);

            var painelDeCotacoes = new PainelDeCotacoes();
            using (var subscription = broker.Subscribe<Acao>(painelDeCotacoes))
            {
                while(true)
                {
                    Console.Write("Informe o código da ação:");
                    var codigo = Console.ReadLine();
                    if (acoes.ContainsKey(codigo))
                    {
                        var acao = acoes[codigo];
                        Console.WriteLine("Informe o nome valor da ação:");
                        var valor = Convert.ToDecimal(Console.ReadLine());
                        acao.Valor = valor;
                    }
                    else
                        Console.WriteLine("Acao não encontrada.");
                }
            }
        }
    }
}
