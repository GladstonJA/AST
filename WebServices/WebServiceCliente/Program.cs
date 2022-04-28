using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ws = new StockQuoteWS.WebService1())
            {
                var acoes = ws.ListarAcoes();
                foreach(var acao in acoes)
                    Console.WriteLine($"Ação: {acao.Name} = {acao.Price}");
            }

            Console.Read();
        }
    }
}
