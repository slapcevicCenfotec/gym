var selected = [];
var table;
var serviceFormula = new ServicioEnClases.ServicioFormulas();

$(document).ready(function () {

    serviceFormula.obtenerFormulas(onSuccessFormulas, null, null);

});


function onSuccessFormulas(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Formulas + '</td>';
        tbody += '<td>' + objeto[i].Descripcion + '</td>';
        tbody += '</tr>';
    });
    $('#tblFormulas tbody').append(tbody);
    //$('#divMostrarHuesos').removeClass('ocultar');
}