function load() {
    var table = $('#tblTiposDeMaquinas').DataTable({
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

    $('#tblTiposDeMaquinas tbody').on('click', 'tr', function () {
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
    var service = new ServiciosTiposDeMaquinas();
    service.obtenerTiposDeMaquinas(onSuccess, null, null);
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
        tbody += '<td>' + object[i].Nombre + '</td>';
        tbody += '<td>' + object[i].Descripcion + '</td>';
        tbody += '<td>' + object[i].Cantidad + '</td>';
        tbody += '</tr>';
    });
    $('#tblTiposDeMaquinas tbody').append(tbody);
    load();
}

$('#btnAgregar').click(function () {
    window.location = 'Registrar.aspx';
})


$('#btnModificar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblTiposDeMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idTipoDeMaquina = rowData[0][0];
    window.location = "Modificar.aspx?id=" + idTipoDeMaquina;
})

$('#btnEliminarMaquina').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblTiposDeMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];

    var serviceBuscarTipoDeMaquinaPorId = new ServicioEnClases.ServiciosMaquina();
    var tipoDeMaquinaPorEliminar = serviceBuscarMaquinaPorId.obtenerTipoDeMaquinaById(idMaquina, onSuccessObtenerMaquina, null, null);

    var serviceEliminar = new ServicioEnClases.ServiciosTiposDeMaquinas();

    serviceEliminar.eliminarTipoDeMaquina(tipoDeMaquinaPorEliminar, onSuccesEliminarTipoMaquina, errorMessage, null, null);
})

function onSuccesEliminarTipoMaquina(result) {
    alert('Se eliminó correctamente el tipo de máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}