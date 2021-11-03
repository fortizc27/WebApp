"use strict";
var TI_Edit;
(function (TI_Edit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(TI_Edit || (TI_Edit = {}));
//# sourceMappingURL=Edit.js.map