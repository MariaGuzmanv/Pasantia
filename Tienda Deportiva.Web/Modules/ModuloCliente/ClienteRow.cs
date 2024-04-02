using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloCliente
{
    public class ClienteRow
    {
        [ConnectionKey("Default"), Module("ClienteModule"), TableName("Clientes")]
        [DisplayName("Clientes"), InstanceName("Cliente")]
        [ReadPermission("Administration:General")]
        [ModifyPermission("Administration:General")]
        public sealed class ClienteRow : Row<ClienteRow.RowFields>, IIdRow, INameRow
        {
            [DisplayName("ID"), Identity, IdProperty]
            public int? ID_Cliente
            {
                get => fields.ID_Cliente[this];
                set => fields.ID_Cliente[this] = value;
            }

            [DisplayName("Nombre"), Size(50), NotNull, QuickSearch, NameProperty]
            public string Nombre
            {
                get => fields.Nombre[this];
                set => fields.Nombre[this] = value;
            }

            [DisplayName("Apellidos"), Size(50), NotNull]
            public string Apellidos
            {
                get => fields.Apellidos[this];
                set => fields.Apellidos[this] = value;
            }

            [DisplayName("Dirección"), Size(100), NotNull]
            public string Dirección
            {
                get => fields.Dirección[this];
                set => fields.Dirección[this] = value;
            }

            [DisplayName("Teléfono"), Size(20), NotNull]
            public string Teléfono
            {
                get => fields.Teléfono[this];
                set => fields.Teléfono[this] = value;
            }

            [DisplayName("Email"), Size(50), NotNull, Unique]
            public string Email
            {
                get => fields.Email[this];
                set => fields.Email[this] = value;
            }

            public class RowFields : RowFieldsBase
            {
                public Int32Field ID_Cliente;
                public StringField Nombre;
                public StringField Apellidos;
                public StringField Dirección;
                public StringField Teléfono;
                public StringField Email;
            }
        }
    }
}
}