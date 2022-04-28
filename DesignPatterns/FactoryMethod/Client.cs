using FactoryMethod.Produtos.Biometria;
using FactoryMethod.Produtos.Senha;
using System;

namespace FactoryMethod
{
    public abstract class Client
    {
        public PasswordControl PasswordControl { get; private set; }

        public LeitorBiometrico LeitorBiometrico { get; private set; }

        protected abstract ColetorDeCredenciaisFactory BuildColetorDeCredenciais();

        public Client()
        {
            var coletorDeCredenciaisFactory = BuildColetorDeCredenciais();

            PasswordControl = coletorDeCredenciaisFactory.CreatePasswordControl();
            LeitorBiometrico = coletorDeCredenciaisFactory.CreateLeitorBiometrico();
        }
    }
}
