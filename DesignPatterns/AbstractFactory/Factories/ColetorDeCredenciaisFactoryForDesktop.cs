using AbstractFactory.Produtos.Biometria;
using AbstractFactory.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
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