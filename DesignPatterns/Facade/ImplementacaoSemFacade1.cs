using Facade.AutorizadorDeCartao;
using System;

namespace Facade
{
    public class ImplementacaoSemFacade1
    {
        public void OperacaoComPreCaptura()
        {
            var gestaoDeRisco = new GestaoDeRisco();
            var notificador = new Notificador();
            var processador = new Processador();
            var autenticador = new Autenticador();

            autenticador.AutenticarPontoDeVenda();
            processador.RegistrarPreCaptura();
            gestaoDeRisco.AvaliarRiscoDaTransacao();
            processador.ValidarCHIP();
            processador.ConfirmarAutorizacaoDaTransacao();
            notificador.NotificadorTransacao();
        }
    }
}
