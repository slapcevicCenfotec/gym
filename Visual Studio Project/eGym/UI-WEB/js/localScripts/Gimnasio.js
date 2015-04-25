var selected = [];
var table;
var serviceGimnasio = new ServicioEnClases.ServicioGimnasio();
var objetoPermisos;
var idGym;

$(document).ready(function () {
    serviceGimnasio.obtenerGimnasioPorId(onSuccessGimnasioPorId, errorMessage, null, null);
});


function ModificarGimnasio() {
    nombre = $('#nombre').val(),
    ubicacion = $('#ubicacion').val();
    telefono = $('#telefono').val();
    fax = $('#fax').val();
    cedula = $('#cedula').val();

    var datos = JSON.stringify({ pId: idGym, pnombre: nombre, pubicacion: ubicacion, ptelefono: telefono, pfax: fax, pcedula: cedula });
    serviceGimnasio.ModificarGimnasio(datos, onSuccesModificar, errorMessage, null, null);

}
function onSuccesModificar(result) {
    alert('Se modifico correctamente el gimnasio');
}
function errorMessage(resul) {
    alert(resul.get_message());
}

function onSuccessGimnasioPorId(result) {
    var objeto = $.parseJSON(result);
    var input = "";
    $.each(objeto, function (i, item) {
        idGym = objeto[i].Id;
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="nombre" value="' + objeto[i].Nombre + '">';
        input += '<label for="nombre">Nombre</label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="ubicacion" value="' + objeto[i].Ubicacion + '">';
        input += '<label for="ubicacion">Ubicacion</label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="telefono" value="' + objeto[i].Telefono + '">';
        input += '<label for="telefono">Telefono</label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="fax" value="' + objeto[i].Fax+ '">';
        input += '<label for="fax">Fax</label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="cedula" value="' + objeto[i].CedulaJuridica+ '">';
        input += '<label for="cedula">Cedula Juridica</label>';
        input += '</div>';
    });
    $('#form1').append(input);
    //SelecionarPermisos(result);
    //load();
    //$('#divMostrarHuesos').removeClass('ocultar');
}