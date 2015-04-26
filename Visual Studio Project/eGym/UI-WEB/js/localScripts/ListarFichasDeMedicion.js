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
    var service = new ServicioFichasDeMedicion();
    service.obtenerFichasDeMedicion(onSuccess, null, null);
}

function error(result) {
    alert(result);
}

function onSuccess(result) {
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
    window.location = 'Registrar.aspx';
})

$('#btnModificar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblFichasDeMedicion').DataTable();
    var rowData = table.rows(rows).data();
    var idFicha = rowData[0][0];
    window.location = "Modificar.aspx?id=" + idFicha;
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