using FactoryMethod.Produtos;
using FactoryMethod.Produtos.Biometria;
using FactoryMethod.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class ColetorDeCredenciaisFactory
    {
        public abstract LeitorBiometrico CreateLeitorBiometrico();

        public abstract PasswordControl CreatePasswordControl();
    }
}
