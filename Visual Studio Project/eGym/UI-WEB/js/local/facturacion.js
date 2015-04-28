function load() {
    var table = $('#tblTiposPago').DataTable({
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

    $('#tblTiposPago tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}


function getAllTipoDePago() {
    var servicio = new ServicioEnClases.ServicioTipoPago();
    servicio.getAllTipoDePago(onSuccessGetAllTP, null, null);
}
function getMisPagos() {
    var servicio = new ServicioEnClases.ServicioPago();
    servicio.getPagoPorUsuario(onSuccessGetAllTP, null, null);
}
function onSuccesIngresar(result) {
    ///alert('Se registró correctamente el tipoDePago');
    location.href = "index.aspx";
}
function onSuccesModificar(result) {
    location.href = "index.aspx";
}
function onSuccesEliminar(result) {
    location.href = "index.aspx";
}
function onSuccessGetAllTP(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";

    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Nombre+ '</td>';
        tbody += '<td>' + objeto[i].Monto + '</td>';
        tbody += '<td>' + objeto[i].Duracion + '</td>';
        tbody += '</tr>';
    });
    $('#tblTiposPago tbody').append(tbody);
    load();
}
function ingresarTipoDePago() {
    var auxNombre = $('#txtNombre').val(),
         auxMonto = $('#txtMonto').val(),
         auxDuracionen = $('#txtDuracion').val(),
         servicio = new ServicioEnClases.ServicioTipoPago();

    var datos = JSON.stringify({ nombre: auxNombre, monto: auxMonto, duracion: auxDuracionen});
    servicio.insertarTipoDePago(datos, onSuccesIngresar, null, null, null);
};
function modificarTipoDePago() {
        var idTipoPago = getQueryVariable('id');
         auxNombre = $('#txtNombre').val(),
         auxMonto = $('#txtMonto').val(),
         auxDuracionen = $('#txtDuracion').val(),
         servicio = new ServicioEnClases.ServicioTipoPago();

         var datos = JSON.stringify({ id: idTipoPago, nombre: auxNombre, monto: auxMonto, duracion: auxDuracionen });
         servicio.modificarTipoDePago(datos, onSuccesModificar, null, null, null);
};
function eliminarTipoDePago() {
    var rows = $('tr.selected');
    var table = $('#tblTiposPago').DataTable();

    var rowData = table.rows(rows).data();
    var auxId = rowData[0][0];

    var servicio = new ServicioEnClases.ServicioTipoPago();
    var datos = JSON.stringify({ pId: auxId });

    servicio.eliminarTipoDePago(datos, onSuccesEliminar, onFail, null, null);
};
function onFail() {
    alert("fail");
}
$("#indexModificar").click(function () {
    var rows = $('tr.selected');
    var table = $('#tblTiposPago').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][0];

    location.href = "modificar.aspx?id=" + id;
});
$("#indexEliminar").click(function () {
    eliminarTipoDePago();
});
$("#indexAgregar").click(function () {
    location.href = "registar.aspx";
});
