
namespace Sport.Usuario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Usuario/DetallePedido"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DetallePedidoRow))]
    public class DetallePedidoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Usuario/DetallePedido/DetallePedidoIndex.cshtml");
        }
    }
}