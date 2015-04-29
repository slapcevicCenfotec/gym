

function search() {
    var service = new ServicioEnClases.ServicioMensaje();
    service.obtenerMensajes(onSuccess);
}



function conversacion(id) {
    var service = new ServicioEnClases.ServicioMensaje();
    var datos = JSON.stringify({
        pDestinatarioId: id
    });
    sessionId = id;
    service.obtenerMensajesPorUsuario(datos, onSuccessId, error);
}

function onSuccessId(result) {
    var object = $.parseJSON(result);
    var ul = document.getElementById("conver");

    $.each(object, function (i, item) {
        var tdiv = '';
        var li = document.createElement("li");
        var d = new Date(parseInt(object[i].FechaYHora.replace(/\/Date\((.*?)\)\//gi, "$1")));
        if (object[i].Destinatario.Id == sessionId) {
            // YO
            tdiv += '<div class="timeline-circ"></div>';
            tdiv += '<div class="timeline-entry">';
            tdiv += '<div class="card style-default-light">';
            tdiv += '<div class="card-body small-padding">';
            tdiv += '<p>';
            tdiv += '<img class="img-circle img-responsive pull-left width-1" src="http://misdeberes.es/img/avatars/65-ON.png" alt="">';
            tdiv += '<span class="text-medium"><a class="text-primary">Yo</a> a las <span class="text-primary">' + [d.getHours(), d.getMinutes()].join(':') + '</span></span><br>';
            tdiv += '<span class="opacity-50">' + [d.getDate(), d.getMonth() + 1, d.getFullYear()].join('/') + '</span>';
            tdiv += '</p>';
            tdiv += object[i].Texto;
            tdiv += '</div>';
            tdiv += '</div>';
            tdiv += '</div>';
        } else {
            li.classList.add("timeline-inverted");
            tdiv += '<div class="timeline-circ"></div>';
            tdiv += '<div class="timeline-entry">';
            tdiv += '<div class="card style-default-light">';
            tdiv += '<div class="card-body small-padding">';
            tdiv += '<p>';
            tdiv += '<img class="img-circle img-responsive pull-left width-1" src="http://misdeberes.es/img/avatars/65-ON.png" alt="">';
            tdiv += '<span class="text-medium">Mensaje recibido de <a class="text-primary">' + object[i].Remitente.NombreCompleto + '</a> a las <span class="text-primary">' + [d.getHours(), d.getMinutes()].join(':') + '</span></span><br>';
            tdiv += '<span class="opacity-50">' + [d.getDate(), d.getMonth() + 1, d.getFullYear()].join('/') + '</span>';
            tdiv += '</p>';
            tdiv += object[i].Texto;
            tdiv += '</div>';
            tdiv += '</div>';
            tdiv += '</div>';
        }

        li.innerHTML = tdiv;
        ul.appendChild(li);
    });
}

function error(result) {
    alert('error' + result);
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
