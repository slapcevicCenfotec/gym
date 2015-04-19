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
            "search": '<i class="fa fa-search"></i>',
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
    var service = new ServicioEnClases.ServiciosMaquinas();
    service.obtenerMaquinas(onSuccessMaquinas, null, null);
}

function error(result) {
    alert(result);
}

function onSuccessMaquinas(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td>' + object[i].NumeroActivo + '</td>';
        tbody += '<td>' + object[i].NumeroMaquina + '</td>';
        tbody += '<td>' + objeto[i].NombreTipoMaquina + '</td>';
        tbody += '</tr>';
    });
    $('#tblMaquinas tbody').append(tbody);
    load();
}

$('#btnAgregar').click(function () {
    window.location = 'Maquinas/Registrar.aspx';
})

$('#btnModificarMaquina').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];
    window.location = "Maquinas/Modificar.aspx?id=" + idMaquina;
})

$('#btnEliminarMaquina').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];

    var serviceBuscarMaquinaPorId = new ServicioEnClases.ServiciosMaquina();
    var maquinaPorEliminar = serviceBuscarMaquinaPorId.obtenerMaquinaById(idMaquina, onSuccessObtenerMaquina, null, null);

    var serviceEliminar = new ServicioEnClases.ServiciosMaquina();

    serviceEliminar.eliminarMaquina(maquinaPorEliminar, onSuccesEliminarMaquina, errorMessage, null, null);
})

$('#btnTiposDeMaquinas').click(function () {
    window.location = "TiposDeMaquinas/Index.aspx?";
})

function onSuccesEliminarMaquina(result) {
    alert('Se eliminó correctamente la máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}
