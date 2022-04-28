using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.InterfaceSegregationPrinciple.PrimeiraProposta
{
    public interface ICliente
    {
        void atualizarCadastro();

        void processarFatura();
    }

    public class OnboardingWorkflow
    {
        public void DoSomething(ICliente cliente) {
        }
    }

    public class AtendimentoACliente
    {
        public void DoSomething(ICliente cliente) {
        }
    }
}
