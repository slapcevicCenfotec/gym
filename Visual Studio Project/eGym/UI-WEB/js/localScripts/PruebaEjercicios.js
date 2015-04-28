var selected = [];
var table;
var serviceEjericios = new ServicioEnClases.ServicioEjercicio();
var servicePruebas = new ServicioEnClases.ServicioPruebasResistencia();

$(document).ready(function () {
    var resulId = getParameterByName("id");
    var resulMode = getParameterByName("Mode");
    if (resulMode === "") {
        var datos = JSON.stringify({ pid: resulId });
        servicePruebas.ObtenerPruebaPorId(datos, onSuccessPruebas, null, null);
    } else if (resulMode === "Ins") {
        serviceEjericios.obtenerEjercicios(onSuccessObtenerEjercicios, null, null);
    } else if (resulMode === "Upd") {
        var datos = JSON.stringify({ pid: resulId });
        servicePruebas.ObtenerPruebaPorId(datos, onSuccessPruebasModificar, null, null);
    }


});

function errorMessage(resul) {
    alert(resul.get_message());
}

$('#btnGuardar').click(function () {
    var cantPermisos = 0;
    var resulId = getParameterByName("id");
    var series = $('#series').val(),
        repeticiones = $('#repeticiones').val(),
        peso = $('#peso').val(),
        idEjericio = $('#selectEjercicio').val();
        rm1 = $('#rm1').val();
        var datos = JSON.stringify({ pidPrueba: resulId, pseries: series, prepeticiones: repeticiones, ppeso: peso, prm1: rm1, pidEjercicio: idEjericio });
        servicePruebas.insertarPruebasEjercicio(datos, onSuccessinsertarPruebasEjercicio, errorMessage, null, null);
});

function onSuccessinsertarPruebasEjercicio(result) {
    alert('Se registró correctamente la prueba');
}


function onSuccessObtenerEjercicios(result) {
    var objeto = $.parseJSON(result);
    var selectEjercicio = "";
    selectEjercicio += '<div class="form-group floating-label">';
    selectEjercicio += '<label for="select13">Ejercicio</label>';
    selectEjercicio += '<div class="col-sm-10">';
    selectEjercicio += '<select id="selectEjercicio" name="select13" class="form-control">';
    selectEjercicio += '<option value="">&nbsp;</option>';
    $.each(objeto, function (i, item) {
        selectEjercicio += '<option value="' + objeto[i].Id + '">' + objeto[i].Nombre + '</option>'
    });
    selectEjercicio += '</select><div class="form-control-line"></div>';
    selectEjercicio += '</div>';
    selectEjercicio += '</div>';
    $('#PruebaEjericiosForm').append(selectEjercicio);
    //$('#divMostrarHuesos').removeClass('ocultar');
    //$("#selectipoPrueba").val(idTipoPrueba);
    //load();
}

function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}