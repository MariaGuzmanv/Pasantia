using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloCliente
{
    public class ClientePage
    {
        [PageAuthorize(typeof(ClienteRow))]
        public class ClientePage : Controller
        {
            [Route("ClienteModule/Cliente")]
            public ActionResult Index()
            {
                return View(MVC.Views.ClienteModule.ClienteIndex);
            }
        }

    }
}