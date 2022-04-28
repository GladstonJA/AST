using FactoryMethod.Produtos.Biometria;
using FactoryMethod.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ColetorDeCredenciaisFactoryForDesktop : ColetorDeCredenciaisFactory
    {
        public override LeitorBiometrico CreateLeitorBiometrico()
        {
            return new ReconhecimentoFacialPorWebCam();
        }

        public override PasswordControl CreatePasswordControl()
        {
            return new TecladoVirtual();
        }
    }
}