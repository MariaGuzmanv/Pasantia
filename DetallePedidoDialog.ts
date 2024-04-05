
namespace Sport.Usuario {

    @Serenity.Decorators.registerClass()
    export class DetallePedidoDialog extends Serenity.EntityDialog<DetallePedidoRow, any> {
        protected getFormKey() { return DetallePedidoForm.formKey; }
        protected getIdProperty() { return DetallePedidoRow.idProperty; }
        protected getLocalTextPrefix() { return DetallePedidoRow.localTextPrefix; }
        protected getService() { return DetallePedidoService.baseUrl; }
        protected getDeletePermission() { return DetallePedidoRow.deletePermission; }
        protected getInsertPermission() { return DetallePedidoRow.insertPermission; }
        protected getUpdatePermission() { return DetallePedidoRow.updatePermission; }

        protected form = new DetallePedidoForm(this.idPrefix);

    }
}