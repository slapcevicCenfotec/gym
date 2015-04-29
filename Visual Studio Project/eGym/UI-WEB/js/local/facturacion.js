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
function load2() {
    var table = $('#tblUsuarios').DataTable({
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
function parseJsonDate(jsonDateString) {
    var date = new Date(parseInt(jsonDateString.replace('/Date(', '')));
    return formattedDate(date);
}

function formattedDate(date) {
    var d = new Date(date || Date.now()),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [month, day, year].join('/');
}

function getAllTipoDePago() {
    var servicio = new ServicioEnClases.ServicioTipoPago();
    servicio.getAllTipoDePago(onSuccessGetAllTP, onFail, null, null);
}
function getAllTipoDePagoSelect() {
    var servicioSelect = new ServicioEnClases.ServicioTipoPago();
    servicioSelect.getAllTipoDePago(onSuccessGetAllSELECT, onFail, null, null);
}
function getAllUsers() {
    var service = new ServicioEnClases.ServicioTipoPago();
    service.ObtenerUsuarios(onSuccessUsers, null, null);
}

function getAllPagos() {
    var servicio = new ServicioEnClases.ServicioTipoPago();
    servicio.getAllPago(onSuccessGetAllPagos, onFail, null, null);
}

function getMisPagos(item) {
    var servicio = new ServicioEnClases.ServicioTipoPago();

    var datos = JSON.stringify({ pId: item });
    servicio.getPagoPorUsuario(datos, onSuccessMisPagos, onFail, null, null);

}
function onSuccesIngresar(result) {
    ///alert('Se registró correctamente el tipoDePago');
    location.href = "index.aspx";
}
("#regresarButton").click(function () {
    location.href = "index.aspx";
});
function volverIndex() {
    location.href = "index.aspx";
}
function OnSuccessRegistrarPago(result) {
    location.href = "index.aspx";
}
function onSuccesModificar(result) {
    location.href = "index.aspx";
}
function onSuccesEliminar(result) {
    location.href = "index.aspx";
}
function onSuccessUsers(result) {
    var object = $.parseJSON(result);
    console.log(object);
    var tbody = "";
    $.each(object, function (i, item) {
        if (object[i].Rol.Id == 19) {
            tbody += '<tr>';
            tbody += '<td style="display:none">' + object[i].Id + '</td>';
            tbody += '<td>' + object[i].Identificacion + '</td>';
            tbody += '<td>' + object[i].Nombre + ' ' + object[i].Apellido + '</td>';
            tbody += '</tr>';
        }
    });
    $('#tblUsuarios tbody').append(tbody);
    load2();
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

function onSuccessGetAllSELECT(result) {
    var objeto = $.parseJSON(result);
    $.each(objeto, function (i, item) {
        
        var option = $(document.createElement('option'));
        option.text(objeto[i].Nombre).val();
        option.val(objeto[i].Id);
        $('#txtTipo').append(option);
    });
    load();
}

function onSuccessGetAllPagos(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";

    $.each(objeto, function (i, item) {
        tbody += '<tr>';

        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Factura + '</td>';
        tbody += '<td>' + objeto[i].Monto + '</td>';
        tbody += '<td>' + objeto[i].TipoNombre + '</td>';
        tbody += '<td>' + parseJsonDate(objeto[i].Fecha) + '</td>';
        tbody += '<td>' + objeto[i].Nombre + '</td>';
        tbody += '</tr>';
    });
    $('#tblTiposPago tbody').append(tbody);
    load();
}
function onSuccessMisPagos(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";

    $.each(objeto, function (i, item) {
        tbody += '<tr>';

        tbody += '<td style="display:none">' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Factura + '</td>';
        tbody += '<td>' + objeto[i].Monto + '</td>';
        tbody += '<td>' + objeto[i].TipoNombre + '</td>';
        tbody += '<td>' + objeto[i].Fecha + '</td>';
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
    servicio.insertarTipoDePago(datos, onSuccesIngresar, onFail, null, null);
};
function registrarPago(id) {
    
    var auxTipo = $('#txtTipo').val();
    var auxMonto = $('#txtMonto').val();
    var auxFactura = $('#txtFactura').val();
    var auxDesde = $('#txtDesde').val();
    var auxHasta = $('#txtHasta').val();

    servicio = new ServicioEnClases.ServicioTipoPago();
    var datos = JSON.stringify({ factura: auxFactura, monto: auxMonto, tipo: auxTipo, hasta: '2015/4/29', desde: '2015/4/29', usuario: id });
    servicio.insertarPago(datos, OnSuccessRegistrarPago, onFail, null, null);

}
function modificarTipoDePago() {
        var idTipoPago = getQueryVariable('id');
         auxNombre = $('#txtNombre').val(),
         auxMonto = $('#txtMonto').val(),
         auxDuracionen = $('#txtDuracion').val(),
         servicio = new ServicioEnClases.ServicioTipoPago();

         var datos = JSON.stringify({ id: idTipoPago, nombre: auxNombre, monto: auxMonto, duracion: auxDuracionen });
         servicio.modificarTipoDePago(datos, onSuccesModificar, onFail, null, null);
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

    //alert("fail");


}


$("#btnVolverTP").click(function () {
    location.href = "index.aspx";
});

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

function agregarTipoPago() {
    location.href = "registar.aspx";
}
function modificarTipoPago() {
    var rows = $('tr.selected');
    var table = $('#tblTiposPago').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][0];

    location.href = "modificar.aspx?id=" + id;
};
function eliminarTipoPago() {

    eliminarTipoDePago();
};
