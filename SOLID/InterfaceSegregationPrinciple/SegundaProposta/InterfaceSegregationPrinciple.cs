using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.InterfaceSegregationPrinciple.SegundaProposta
{
    public interface IProspect
    {
        void atualizarCadastro();
    }

    public interface ICliente : IProspect
    {
        void processarFatura();
    }

    public class OnboardingWorkflow
    {
        public void DoSomething(IProspect cliente)
        {
            cliente.atualizarCadastro();
        }
    }

    public class AtendimentoACliente
    {
        public void DoSomething(ICliente cliente)
        {
            cliente.atualizarCadastro();
            cliente.processarFatura();
        }
    }
}
