using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloProducto
{
    public class ProductoPage
    {
        [PageAuthorize(typeof(ProductoRow))]
        public class ProductoPage : Controller
        {
            [Route("ProductoModule/Producto")]
            public ActionResult Index()
            {
                return View(MVC.Views.ProductoModule.ProductoIndex);
            }
        }

    }
}