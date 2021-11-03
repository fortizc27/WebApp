"use strict";
var TI_Grid;
(function (TI_Grid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: 'success', title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "#d33").then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "TipoIdentificacion/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    TI_Grid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(TI_Grid || (TI_Grid = {}));
//# sourceMappingURL=Grid.js.map