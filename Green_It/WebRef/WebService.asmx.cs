using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Green_It.WebRef
{
    /// <summary>
    /// Description résumée de WebService
    /// </summary>
    [WebService(Namespace = "http://localhost:50238/WebRef/WebService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Randam()
        {
            Random _Random = new Random();
            return _Random.Next();
        }
    }
}
