using Serenity.Services;

namespace Tienda_Deportiva.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}