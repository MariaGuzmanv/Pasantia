
namespace Sport.Usuario.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Usuario"), TableName("[ped].[Detalle_Pedido]")]
    [DisplayName("Detalle Pedido"), InstanceName("Detalle Pedido")]
    [ReadPermission("Cliente:General")]
    [ModifyPermission("Cliente:General")]
    public sealed class DetallePedidoRow : Row, IIdRow
    {
        [DisplayName("Id Detalle"), Column("id_detalle"), Identity]
        public Int32? IdDetalle
        {
            get { return Fields.IdDetalle[this]; }
            set { Fields.IdDetalle[this] = value; }
        }

        [DisplayName("Id Pedido"), Column("id_pedido"), NotNull, ForeignKey("[ped].[Pedidos]", "id_pedido"), LeftJoin("jIdPedido"), TextualField("IdPedidoEstado")]
        public Int64? IdPedido
        {
            get { return Fields.IdPedido[this]; }
            set { Fields.IdPedido[this] = value; }
        }

        [DisplayName("Id Producto"), Column("id_producto"), NotNull, ForeignKey("[ped].[Producto]", "Id_producto"), LeftJoin("jIdProducto"), TextualField("IdProductoProducto")]
        public Int32? IdProducto
        {
            get { return Fields.IdProducto[this]; }
            set { Fields.IdProducto[this] = value; }
        }

        [DisplayName("Cantidad"), NotNull]
        public Int64? Cantidad
        {
            get { return Fields.Cantidad[this]; }
            set { Fields.Cantidad[this] = value; }
        }

        [DisplayName("Precio"), NotNull]
        public Int32? Precio
        {
            get { return Fields.Precio[this]; }
            set { Fields.Precio[this] = value; }
        }

        [DisplayName("Sub Total"), Column("Sub_Total"), NotNull]
        public Int64? SubTotal
        {
            get { return Fields.SubTotal[this]; }
            set { Fields.SubTotal[this] = value; }
        }

        [DisplayName("Id Pedido Fecha"), Expression("jIdPedido.[Fecha]")]
        public DateTime? IdPedidoFecha
        {
            get { return Fields.IdPedidoFecha[this]; }
            set { Fields.IdPedidoFecha[this] = value; }
        }

        [DisplayName("Id Pedido Estado"), Expression("jIdPedido.[Estado]")]
        public String IdPedidoEstado
        {
            get { return Fields.IdPedidoEstado[this]; }
            set { Fields.IdPedidoEstado[this] = value; }
        }

        [DisplayName("Id Pedido Id Cliente"), Expression("jIdPedido.[id_cliente]")]
        public Int64? IdPedidoIdCliente
        {
            get { return Fields.IdPedidoIdCliente[this]; }
            set { Fields.IdPedidoIdCliente[this] = value; }
        }

        [DisplayName("Id Pedido Total"), Expression("jIdPedido.[Total]")]
        public Int32? IdPedidoTotal
        {
            get { return Fields.IdPedidoTotal[this]; }
            set { Fields.IdPedidoTotal[this] = value; }
        }

        [DisplayName("Id Producto Producto"), Expression("jIdProducto.[Producto]")]
        public String IdProductoProducto
        {
            get { return Fields.IdProductoProducto[this]; }
            set { Fields.IdProductoProducto[this] = value; }
        }

        [DisplayName("Id Producto Cantidad"), Expression("jIdProducto.[Cantidad]")]
        public Int32? IdProductoCantidad
        {
            get { return Fields.IdProductoCantidad[this]; }
            set { Fields.IdProductoCantidad[this] = value; }
        }

        [DisplayName("Id Producto Precio"), Expression("jIdProducto.[Precio]")]
        public Int64? IdProductoPrecio
        {
            get { return Fields.IdProductoPrecio[this]; }
            set { Fields.IdProductoPrecio[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdDetalle; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DetallePedidoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdDetalle;
            public Int64Field IdPedido;
            public Int32Field IdProducto;
            public Int64Field Cantidad;
            public Int32Field Precio;
            public Int64Field SubTotal;

            public DateTimeField IdPedidoFecha;
            public StringField IdPedidoEstado;
            public Int64Field IdPedidoIdCliente;
            public Int32Field IdPedidoTotal;

            public StringField IdProductoProducto;
            public Int32Field IdProductoCantidad;
            public Int64Field IdProductoPrecio;
        }
    }
}
