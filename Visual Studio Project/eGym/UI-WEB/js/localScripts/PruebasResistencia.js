var selected = [];
var table;
var servicePruebas = new ServicioEnClases.ServicioPruebasResistencia();
var objetoEjercicios;
$(document).ready(function () {
    var resulId = getParameterByName("id");
    var resulMode = getParameterByName("Mode");
    if (resulMode === "") {
        var datos = JSON.stringify({ pid: resulId });
        servicePruebas.ObtenerPruebaPorId(datos, onSuccessPruebas, null, null);
    } else if (resulMode === "Ins") {
        servicePruebas.obtenerTipoPruebasResistencia(onSuccessTipoPrueba, null, null);
    } else if (resulMode === "Upd") {
        var datos = JSON.stringify({ pid: resulId });
        serviceRol.obtenerRolPorId(datos, onSuccessRolesPorId, errorMessage, null, null);
    }


});




function onSuccessPruebas(result) {
    var objeto = $.parseJSON(result);
    var label = "";
    var tr = "";
    $.each(objeto, function (i, item) {
        label += '<div class="form-group">';
        label += '<label for="id" style="display:none id="pid"><h4>Id: ' + objeto[i].Id + '</h4></label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="descripcion"><h4>Usuario: ' + objeto[i].NombreUsuario + '</h4></label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="nombre"><h4>Peso: ' + objeto[i].Peso + '</h4></label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="descripcion"><h4>Tipo Prueba: ' + objeto[i].NombrePrueba + '</h4></label>';
        label += '</div>';

    });
    $('#prbResistencia').append(label);


    objetoEjercicios = objeto[0].ListaPruebas;

    $.each(objetoEjercicios, function (i, item) {
        tr+='<tr>';
        tr += '<td class="tg-031e">'+objetoEjercicios[i].Nombre+'</td>';
        tr+='<td class="tg-031e">3</td>';
        tr+='<td class="tg-031e">4</td>';
        tr+='<td class="tg-031e">47.55</td>';
        tr+='<td class="tg-031e">30.25<br></td>'
        tr+='<td class="tg-031e">37.5</td>'
        tr+='<td class="tg-031e">37.5</td>'
        tr+='<td class="tg-031e">25</td>'
        tr += '</tr>'
    });
    $('#tblPruebas').append(tr);


}

function onSuccessTipoPrueba(result) {
    var objeto = $.parseJSON(result);
    var selectPrueba = "";
    $.each(objeto, function (i, item) {

        selectPrueba += '<option value="">&nbsp;</option>';
        selectPrueba += '<td>' + objeto[i].Id + '</td>';
        selectPrueba += '<option value="' + objeto[i].Id + '">' + objeto[i].Nombre + '</option>'

    });
    $('#select13').append(selectPrueba);
    //$('#divMostrarHuesos').removeClass('ocultar');
}

$('#btnAgregarPrueba').click(function () {
    window.location = "Agregar.aspx?Mode=Ins";
});

$('#btnModificarPruebaResistencia').click(function () {
    var idPruebaResistencia = $('#pid').val();
    window.location = "Agregar.aspx?Mode=Ins";
});

function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}