var selected = [];
var table;

$(document).ready(function () {
    var service = new ServicioEnClases.ServiciosMaquinas();
    service.obtenerMaquinas(onSuccessMaquinas, null, null);
});

function onSuccessMaquinas(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].NumeroActivo + '</td>';
        tbody += '<td>' + objeto[i].NumeroMaquina + '</td>';
        tbody += '<td style="display:none">' + objeto[i].Habilitado + '</td>';
        tbody += '<td style="display:none">' + objeto[i].TipoDeMaquina + '</td>';
        tbody += '<td>' + objeto[i].NombreTipoMaquina + '</td>';
        tbody += '</tr>';
    });
    $('#tblMaquinas tbody').append(tbody);
    load();
}

function load() {

    table = $('#tblMaquinas').DataTable();

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

$('#btnAgregarMaquina').click(function () {
    window.location = 'FrmRegistrarMaquinaWeb.aspx';
})

$('#btnModificarMaquina').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];
    var numeroActivo = rowData[0][1];
    var numeroMaquina = rowData[0][2];
    var habilitado = rowData[0][3];
    var tipoMaquina = rowData[0][4];
    var nombreMaquina = rowData[0][5];
    window.location = "FrmModificarMaquinaWeb.aspx?id=" + idMaquina;
})

$('#btnEliminarMaquina').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMaquinas').DataTable();
    var rowData = table.rows(rows).data();
    var idMaquina = rowData[0][0];
    var numeroActivo = rowData[0][1];
    var numeroMaquina = rowData[0][2];
    var habilitado = rowData[0][3];
    var tipoMaquina = rowData[0][4];
    var serviceEliminar = new ServicioEnClases.ServiciosMaquina();

    datos = JSON.stringify({ pid: idMaquina, pnumeroActivo: numeroActivo, pnumeroMaquina: numeroMaquina, phabilitado: habilitado, ptipoMaquina: tipoMaquina });
    serviceEliminar.eliminarMaquina(datos, onSuccesEliminarMaquina, errorMessage, null, null);
})

$('#btnTiposDeMaquinas').click(function () {
    window.location = "FrmListarTiposDeMaquinasWeb.aspx?";
})

function onSuccesEliminarMaquina(result) {
    alert('Se eliminó correctamente el Musculo');
}

function errorMessage(resul) {
    alert(resul.get_message());
}
