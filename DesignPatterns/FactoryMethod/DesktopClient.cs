using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class DesktopClient : Client
    {
        protected override ColetorDeCredenciaisFactory BuildColetorDeCredenciais()
        {
            return new ColetorDeCredenciaisFactoryForDesktop();
        }
    }
}
