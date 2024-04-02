using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloProducto
{
    public class ProductoRow
    {
        [ConnectionKey("Default"), Module("ProductoModule"), TableName("Productos")]
        [DisplayName("Productos"), InstanceName("Producto")]
        [ReadPermission("Administration:General")]
        [ModifyPermission("Administration:General")]
        public sealed class ProductoRow : Row<ProductoRow.RowFields>, IIdRow, INameRow
        {
            [DisplayName("ID"), Identity, IdProperty]
            public int? ID_Producto
            {
                get => fields.ID_Producto[this];
                set => fields.ID_Producto[this] = value;
            }

            [DisplayName("Nombre"), Size(50), NotNull, QuickSearch, NameProperty]
            public string Nombre
            {
                get => fields.Nombre[this];
                set => fields.Nombre[this] = value;
            }

            [DisplayName("Descripción")]
            public string Descripción
            {
                get => fields.Descripción[this];
                set => fields.Descripción[this] = value;
            }

            [DisplayName("Precio"), NotNull]
            public decimal? Precio
            {
                get => fields.Precio[this];
                set => fields.Precio[this] = value;
            }

            [DisplayName("Stock"), NotNull]
            public int? Stock
            {
                get => fields.Stock[this];
                set => fields.Stock[this] = value;
            }

            public class RowFields : RowFieldsBase
            {
                public Int32Field ID_Producto;
                public StringField Nombre;
                public StringField Descripción;
                public DecimalField Precio;
                public Int32Field Stock;
            }
        }

    }
}