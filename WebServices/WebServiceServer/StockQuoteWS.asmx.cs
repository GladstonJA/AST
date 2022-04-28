using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceServer
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Stock[] ListarAcoes()
        {
            return new Stock[] {
                new Stock() { Name = "AZUL4", Price = 45 }
                , new Stock() { Name = "MSFT34", Price = 53 }
            };
        }

        [WebMethod]
        public bool AtualizarAcao(Stock stock)
        {
            return stock != null;
        }
    }
}
