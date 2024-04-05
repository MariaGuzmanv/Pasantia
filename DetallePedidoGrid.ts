
namespace Sport.Usuario {

    @Serenity.Decorators.registerClass()
    export class DetallePedidoGrid extends Serenity.EntityGrid<DetallePedidoRow, any> {
        protected getColumnsKey() { return 'Usuario.DetallePedido'; }
        protected getDialogType() { return DetallePedidoDialog; }
        protected getIdProperty() { return DetallePedidoRow.idProperty; }
        protected getInsertPermission() { return DetallePedidoRow.insertPermission; }
        protected getLocalTextPrefix() { return DetallePedidoRow.localTextPrefix; }
        protected getService() { return DetallePedidoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}