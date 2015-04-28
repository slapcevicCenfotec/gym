$(document).ready(function () {
    var serviceBuscarEjercicos = new ServicioEjercicio();
    serviceBuscarEjercicos.obtenerEjercicios(onSuccessobtenerEjercicios, null, null);

});

//function onSuccessobtenerEjercicios(result) {
//    var objeto = $.parseJSON(result);
//    var cmbTiposDeMaquinas = document.getElementById('cmbTiposDeMaquinas');

//    $.each(objeto, function (i, item) {
//        $("#cmbTiposDeMaquinas").append("<option value=\"" + objeto[i].Id + "\">" + objeto[i].Nombre + "</option>");
//    });
//}