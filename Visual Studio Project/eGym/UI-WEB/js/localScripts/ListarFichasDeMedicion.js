function load() {
    var table = $('#tblFichasDeMedicion').DataTable({
        "dom": 'lCfrtip',
        "order": [],
        "colVis": {
            "buttonText": "Columnas",
            "overlayFade": 0,
            "align": "right"
        },
        "language": {
            "lengthMenu": '_MENU_ entradas por página',
            "Buscar": '<i class="fa fa-search"></i>',
            "paginate": {
                "Anterior": '<i class="fa fa-angle-left"></i>',
                "Siguiente": '<i class="fa fa-angle-right"></i>'
            }
        }
    });


    $('#tblFichasDeMedicion tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}

function search() {

    var idCliente = getQueryVariable('id');
    var idGenero = getQueryVariable('idGenero');

    var idMaquina = getQueryVariable('id');

    var service = new ServicioFichasDeMedicion();
    service.obtenerFichasPorCliente(idCliente, onSuccessObtenerFichas, error2, null);
}

function error2(result) {

    window.location = '../Clientes/index.aspx';
}

function onSuccessObtenerFichas(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none">' + object[i].Id + '</td>';
        tbody += '<td>' + parseJsonDate(object[i].FechaCreacion) + '</td>';
        tbody += '<td>' + object[i].Peso + '</td>';
        tbody += '<td>' + object[i].Altura + '</td>';
        tbody += '<td>' + object[i].Imc + '</td>';
        tbody += '</tr>';
    });
    $('#tblFichasDeMedicion tbody').append(tbody);
    load();
}

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

$('#btnAgregar').click(function () {
    var idGenero = getQueryVariable('idGenero');

    var idCliente = getQueryVariable('id');

    window.location = "Registrar.aspx?id=" + idCliente + "&idGenero=" + idGenero;
})

$('#btnModificar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblFichasDeMedicion').DataTable();
    var rowData = table.rows(rows).data();
    var idFicha = rowData[0][0];

    var idGenero = getQueryVariable('idGenero');

    window.location = "Modificar.aspx?id=" + idFicha + "&idGenero=" + idGenero;
})

$('#btnEliminar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblFichasDeMedicion').DataTable();
    var rowData = table.rows(rows).data();
    var idFicha = rowData[0][0];

    datos = JSON.stringify({ pidFicha: idFicha });

    var serviceEliminar = new ServicioFichasDeMedicion();

    serviceEliminar.eliminarFichaMedicion(datos, onSuccesEliminarFicha, errorMessage, null, null);

    location.reload();
})

$('#btnGraficos').click(function () {
    window.location = 'Graficos.aspx';
})

function onSuccesEliminarFicha(result) {
    alert('Se eliminó correctamente la ficha de medición');
}

function errorMessage(resul) {
    alert(resul.get_message());
}

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split('&');
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split('=');
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
}