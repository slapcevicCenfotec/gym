var selected = [];
var table;
var servicePermiso = new ServicioEnClases.ServicioPermisos();


//$(document).ready(function () {
//    var resulId = getParameterByName("id");
//    var resulMode = getParameterByName("Mode");
//    servicePermiso.obtenerPermiso(onSuccessPermisos, null, null);
//});



function errorMessage(resul) {
    alert(resul.get_message());
}


function onSuccessPermisos(result) {
    var objeto = $.parseJSON(result);
    var Ulist = "";
    $.each(objeto, function (i, item) {
        Ulist += '<li class="tile">';
        Ulist += '<div class="checkbox checkbox-styled tile-text">';
        Ulist += '<label>';
        Ulist += '<input type="checkbox" id="' + objeto[i].Id + '" name="checktodos">';
        Ulist += '<span>' + objeto[i].Nombre + '</span>';
        Ulist += '</label>';
        Ulist += '</div>';
        Ulist += '</li>';
    });
    $('#listaPermisos').append(Ulist);

    $('#listaPermisos li input[type=checkbox]').each(function (i, itemPermiso) {

        var isChecked = false;

        $.each(objetoPermisos, function (i, item) {
            if (itemPermiso.id == item.Id) {
                isChecked = true;
            }
        });
        if (isChecked == true) {
            this.checked = true;
        }
    });
}
