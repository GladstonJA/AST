using AbstractFactory.Produtos.Biometria;
using AbstractFactory.Produtos.Senha;
using System;

namespace AbstractFactory.Produtos
{
    public class Client
    {
        public PasswordControl PasswordControl { get; private set; }

        public LeitorBiometrico LeitorBiometrico { get; private set; }

        public Client(string plataforma)
        {
            var coletorDeCredenciaisFactory = default(ColetorDeCredenciaisFactory);

            if (plataforma.Equals("DESKTOP"))
                coletorDeCredenciaisFactory = new ColetorDeCredenciaisFactoryForDesktop();
            else
                coletorDeCredenciaisFactory = new ColetorDeCredenciaisFactoryForMobile();

            PasswordControl = coletorDeCredenciaisFactory.CreatePasswordControl();
            LeitorBiometrico = coletorDeCredenciaisFactory.CreateLeitorBiometrico();
        }
    }
}
