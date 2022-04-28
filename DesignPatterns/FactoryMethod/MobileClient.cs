using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MobileClient : Client
    {
        protected override ColetorDeCredenciaisFactory BuildColetorDeCredenciais()
        {
            return new ColetorDeCredenciaisFactoryForMobile();
        }
    }
}
