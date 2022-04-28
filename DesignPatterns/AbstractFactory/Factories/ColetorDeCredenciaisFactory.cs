using AbstractFactory.Produtos;
using AbstractFactory.Produtos.Biometria;
using AbstractFactory.Produtos.Senha;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ColetorDeCredenciaisFactory
    {
        public abstract LeitorBiometrico CreateLeitorBiometrico();

        public abstract PasswordControl CreatePasswordControl();
    }
}
