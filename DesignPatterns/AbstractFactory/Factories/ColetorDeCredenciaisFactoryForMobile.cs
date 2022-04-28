using AbstractFactory.Produtos.Biometria;
using AbstractFactory.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
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
