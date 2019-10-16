using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PIndividual.BL;

namespace PIndividual.CM
{
    /// <summary>
    /// Descripción breve de PrimerServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class PrimerServicio : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string RetornoPrueba()
        {

            return "Hola a todos";
        }
    }
}
