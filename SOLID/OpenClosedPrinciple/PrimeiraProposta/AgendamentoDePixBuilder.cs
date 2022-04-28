using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OpenClosedPrinciple.PrimeiraProposta
{
    public class AgendamentoDePixBuilder
    {
        public AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            var result = default(AgendamentoDePix);
            if (solicitacao.TipoDeAgendamento == TipoDeAgendamento.PorChaveDeEnderecamento)
                result = BuildAgendamentoPorChavePix(solicitacao);
            else if (solicitacao.TipoDeAgendamento == TipoDeAgendamento.PorQrCodeEstatico)
                result = BuildAgendamentoPorQrCodeEstatico(solicitacao);
            else if (solicitacao.TipoDeAgendamento == TipoDeAgendamento.PorQrCodeDinamico)
                result = BuildAgendamentoPorQrCodeDinamico(solicitacao);            
            return result;
        }

        protected virtual AgendamentoDePix BuildAgendamentoPorChavePix(SolicitacaoDeAgendamentoDePix solicitacao)
        { return null; }
         
        protected virtual AgendamentoDePix BuildAgendamentoPorQrCodeEstatico(SolicitacaoDeAgendamentoDePix solicitacao)
        { return null; }

        protected virtual AgendamentoDePix BuildAgendamentoPorQrCodeDinamico(SolicitacaoDeAgendamentoDePix solicitacao)
        { return null; }
    }
}
