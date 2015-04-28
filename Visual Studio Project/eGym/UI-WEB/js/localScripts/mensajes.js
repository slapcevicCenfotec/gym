function search() {
    var service = new ServicioEnClases.ServicioMensaje();
    service.obtenerMensajes(onSuccess);
}

function onSuccess(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        var d = new Date(parseInt(object[i].FechaYHora.replace(/\/Date\((.*?)\)\//gi, "$1")));
        tbody += '<tr>';
        if (object[i].Leido) {
            tbody += '<td>' + object[i].Remitente.Id + ' <i class="fa fa-star"></i></td>';
        } else {
            tbody += '<td>' + object[i].Remitente.Id + '</td>';
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