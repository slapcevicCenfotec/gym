var objeto;

$(document).ready(function () {
    var cliente = 122;
    var serviceBuscar = new ServicioFichasDeMedicion();
    serviceBuscar.obtenerFichasPorCliente(cliente, onSuccessBuscarFichas, null, null);
});

function onSuccessBuscarFichas(result) {
    objeto = $.parseJSON(result);
    var cmbTiposDeMaquinas = document.getElementById('cmbDesde');
    var cmbTiposDeMaquinas = document.getElementById('cmbHasta');

    $.each(objeto, function (i, item) {
        $("#cmbDesde").append("<option value=\"" + objeto[i].Id + "\">" + parseJsonDate(objeto[i].FechaCreacion) + "</option>");
        $("#cmbHasta").append("<option value=\"" + objeto[i].Id + "\">" + parseJsonDate(objeto[i].FechaCreacion) + "</option>");
    });
}

$('#btnGenerar').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datos = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

    $.each(objeto, function (i, item) {
        if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
            datos.push({
                x: parseJsonDate(objeto[i].FechaCreacion),
                y: objeto[i].Peso
            });            
        }
    });

    console.log(datos);
    if ($('#grafico').length > 0) {
        var labelColor = $('#grafico').css('color');
        Morris.Area({
            element: 'grafico',
            behaveLikeLine: true,
            data: datos,
            xkey: 'x',
            ykeys: ['y'],
            labels: ['Y'],
            gridTextColor: labelColor,
            lineColors: $('#grafico').data('colors').split(',')
        });
    }
    }
})

function parseJsonDate(jsonDateString) {
    var date = new Date(parseInt(jsonDateString.replace('/Date(', '')));
    return formattedDate(date);
}

function formattedDate(date) {
    var d = new Date(date || Date.now()),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [month, day, year].join('/');
}

