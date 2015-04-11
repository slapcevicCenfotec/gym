function load() {
    table = $('#tblUsuarios').DataTable();

    $('#tblUsuarios tbody').on('click', 'tr', function () {
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
    var service = new ServicioEnClases.ServicioUsuario();
    alert('Entra');
    service.obtenerUsuarios(onSuccess, null, null);
}

function error(result) {
    alert(result);
}

function onSuccess(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + object[i].Identificacion + '</td>';
        tbody += '<td>' + object[i].Nombre + '</td>';
        tbody += '<td>' + object[i].Alias + '</td>';
        tbody += '<td>' + object[i].FechaIngreso + '</td>';
        tbody += '</tr>';
    });
    $('#tblUsuarios tbody').append(tbody);
    load();
}
