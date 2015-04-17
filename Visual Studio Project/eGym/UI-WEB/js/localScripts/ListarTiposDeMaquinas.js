var selected = [];
var table;

$(function () {
    var service = new ServicioEnClases.ServiciosTiposDeMaquinas();
    service.obtenerTiposDeMaquinas(onSuccessTiposDeMaquinas, null, null);
});

function onSuccessTiposDeMaquinas(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td style="display:none">' + objeto[i].Foto + '</td>';
        tbody += '<td>' + objeto[i].Nombre + '</td>';
        tbody += '<td>' + objeto[i].Descripcion + '</td>';
        tbody += '<td style="display:none">' + objeto[i].Habilitado + '</td>';
        tbody += '<td>' + objeto[i].Cantidad + '</td>';
        tbody += '</tr>';
    });
    $('#tblTiposDeMaquinas tbody').append(tbody);
    load();
}

function load() {

    table = $('#tblTiposDeMaquinas').DataTable();

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

$('#btnAgregarTipoDeMaquina').click(function () {
    window.location = 'FrmRegistrarTipoDeMaquinaWeb.aspx';
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