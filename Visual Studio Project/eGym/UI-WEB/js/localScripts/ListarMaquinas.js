function load() {
    var table = $('#tblMaquinas').DataTable({
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

    $('#tblMaquinas tbody').on('click', 'tr', function () {
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
    var service = new ServiciosMaquinas();
    service.obtenerMaquinas(onSuccess, null, null);
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
        tbody += '<td>' + object[i].NumeroActivo + '</td>';
        tbody += '<td>' + object[i].NumeroMaquina + '</td>';
        tbody += '<td>' + object[i].NombreTipoMaquina + '</td>';
        tbody += '</tr>';
    });
    $('#tblMaquinas tbody').append(tbody);
    load();
}

$('#btnAgregar').click(function () {
    window.location = 'Registrar.aspx';
})

$('#btnModificar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];
    window.location = "Modificar.aspx?id=" + idMaquina;
})

$('#btnEliminar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];

    var serviceBuscarMaquinaPorId = new ServiciosMaquinas();
    serviceBuscarMaquinaPorId.obtenerMaquinaById(idMaquina, onSuccessObtenerMaquina, null, null);

    function onSuccessObtenerMaquina(result) {
        var serviceEliminar = new ServiciosMaquinas();

        serviceEliminar.eliminarMaquina(result, onSuccesEliminarMaquina, errorMessage, null, null);

        location.reload();
    }
})

$('#btnTiposDeMaquinas').click(function () {
    window.location = "/egym/TiposDeMaquinas/Index.aspx";
})

function onSuccesEliminarMaquina(result) {
    alert('Se eliminó correctamente la máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}