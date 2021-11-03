namespace TI_Edit {
    var Formulario = new Vue(
        {
            data: {
                Formulario: "#FormEdit"
            },
            mounted() {
                CreateValidator(this.Formulario)
            }
        }
    );

    Formulario.$mount("#AppEdit")
}