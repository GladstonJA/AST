using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OpenClosedPrinciple.TerceiraProposta
{
    public interface IAgendamentoDePixBuilder
    {
        AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao);
    }

    public class AgendamentoDePixPorChavePixBuilder : IAgendamentoDePixBuilder
    {
        public virtual AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class AgendamentoDePixPorQrCodeEstaticoBuilder : IAgendamentoDePixBuilder
    {
        public virtual AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class AgendamentoDePixPorQrCodeDinamicoBuilder : IAgendamentoDePixBuilder
    {
        public virtual AgendamentoDePix Build(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            return null;
        }
    }

    public class UIAgendamentoAgendamentoDePix
    {
        public IAgendamentoDePixBuilder Builder { get; set; }

        public void agendarPix(SolicitacaoDeAgendamentoDePix solicitacao)
        {
            var agendamento = Builder.Build(solicitacao);
        }
    }
}
