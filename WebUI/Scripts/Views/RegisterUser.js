//Controlador de la Vista: RegistrarUsuario.cshtml

function CustomerView() {
    //Atributos
    this.ViewName = "CustomerView";
    this.ApiUrl = "";

    //JQueary framework que facilita el manejo de JS
    //Se invoca con el simbolo de $
    this.InitView = function () {
        $("#btnCreate").click(function () {
            var view = new CustomerView();
            view.CreateCustomer();
        });
    }

    this.CreateCustomer = function () {
        alert("Creando Usuario...Espere!");

    };
}//

//Instanciamiento inicial, siempre se ejecuta cuando la pagina termina de cargar.

$(document).ready(function () {
    var view = new CustomerView();
    view.InitView();
})