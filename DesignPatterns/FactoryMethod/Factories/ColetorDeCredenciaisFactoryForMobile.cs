using FactoryMethod.Produtos.Biometria;
using FactoryMethod.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ColetorDeCredenciaisFactoryForMobile : ColetorDeCredenciaisFactory
    {
        public override LeitorBiometrico CreateLeitorBiometrico()
        {
            return new FingerPrintReader();
        }

        public override PasswordControl CreatePasswordControl()
        {
            return new PasswordTextBox();
        }
    }
}
