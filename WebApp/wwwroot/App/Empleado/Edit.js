"use strict";
var EmpleadEdit;
(function (EmpleadEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(EmpleadEdit || (EmpleadEdit = {}));
//# sourceMappingURL=Edit.js.map