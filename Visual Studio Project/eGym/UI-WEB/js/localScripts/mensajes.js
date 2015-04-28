function search() {
    var service = new ServicioEnClases.ServicioMensaje();
    service.obtenerMensajes(onSuccess);
}

function conversacion(id) {
    var service = new ServicioEnClases.ServicioMensaje();

}

function onSuccess(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        var d = new Date(parseInt(object[i].FechaYHora.replace(/\/Date\((.*?)\)\//gi, "$1")));
        tbody += '<tr>';
        tbody += '<td style="display:none">' + object[i].Remitente.Id + '</td>';
        if (object[i].Leido) {
            tbody += '<td>' + object[i].Remitente.Nombre + ' <i class="fa fa-star"></i></td>';
        } else {
            tbody += '<td>' + object[i].Remitente.Nombre + '</td>';
        }
        tbody += '<td>' + object[i].Texto + '</td>';
        tbody += '<td>' + [d.getDate(),
                           d.getMonth() + 1,
                           d.getFullYear()].join('/') + ' ' +
                           [d.getHours(),
                            d.getMinutes()].join(':') + '</td>';
        tbody += '</tr>';
    });
    $('#tblMensajes tbody').append(tbody);

    load();
}

function load() {
    var table = $('#tblMensajes').DataTable({
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

    $('#tblMensajes tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}

$('#btnLeer').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMensajes').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];
    window.location = "conversacion.aspx?id=" + idMaquina;
})
