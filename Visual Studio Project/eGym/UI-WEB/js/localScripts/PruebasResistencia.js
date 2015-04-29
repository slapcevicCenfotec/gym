var selected = [];
var table;
var servicePruebas = new ServicioEnClases.ServicioPruebasResistencia();
var objetoEjercicios;
var idTipoPrueba;
var idPruebaResistencia;
$(document).ready(function () {
    var resulId = getParameterByName("id");
    var resulMode = getParameterByName("Mode");
    if (resulMode === "") {
        var datos = JSON.stringify({ pid: resulId });
        servicePruebas.ObtenerPruebaPorId(datos, onSuccessPruebas, null, null);
    } else if (resulMode === "Ins") {
        servicePruebas.obtenerTipoPruebasResistencia(onSuccessTipoPrueba, null, null);
    } else if (resulMode === "Upd") {
        var datos = JSON.stringify({ pid: resulId });
        servicePruebas.ObtenerPruebaPorId(datos, onSuccessPruebasModificar, null, null);
    }


});


function onSuccessPruebasModificar(result) {
    var objeto = $.parseJSON(result);
    var input = "";
    var tr = "";
    $.each(objeto, function (i, item) {
        idTipoPrueba = objeto[i].IdTipoPrueba
        idPruebaResistencia = objeto[i].Id;
        input += '<div class="form-group">';
        input += '<label for="idprb" class="col-sm-2 control-label" style="visibility: hidden">idPrb</label>';
        input += '<div class="col-sm-10" >';
        input += '<input type="text" style="visibility: hidden" class="form-control" id="idPrueba" value="' + objeto[i].Id + '">';
        input += '</div>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<label for="nombre"><h4>Usuario: ' + objeto[i].NombreUsuario + '</h4></label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<label for="nombre" class="col-sm-2 control-label">Peso</label>';
        input += '<div class="col-sm-10">';
        input += '<input type="text" class="form-control" id="peso" value="' + objeto[i].Peso + '">';
        input += '</div>';
        input += '</div>';
    });
    $('#PruebasForm').append(input);


    objetoEjercicios = objeto[0].ListaPruebas;

    $.each(objetoEjercicios, function (i, item) {
        tr += '<tr>';
        tr += '<td class="tg-031e" style="display:none">' + objetoEjercicios[i].Id + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Nombre + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Series + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Repeticiones + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Peso + '<br></td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Rm1 + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc1 + '</td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc2 + '</td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc3 + '</td>'
        tr += '</tr>'
    });
    $('#tblPruebas').append(tr);

    servicePruebas.obtenerTipoPruebasResistencia(onSuccessTipoPrueba, null, null);



}

function onSuccessPruebas(result) {
    var objeto = $.parseJSON(result);
    var label = "";
    var tr = "";
    $.each(objeto, function (i, item) {
        label += '<div class="form-group">';
        label += '<label for="id" id="pidPrueba" style="display:none >' + objeto[i].Id + '</label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="descripcion"><h4>Usuario: ' + objeto[i].NombreUsuario + '</h4></label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="nombre"><h4>Peso: ' + objeto[i].Peso + '</h4></label>';
        label += '</div>';
        label += '<div class="form-group">';
        label += '<label for="descripcion"><h4>Tipo Prueba: ' + objeto[i].NombrePrueba + '</h4></label>';
        label += '</div>';

    });
    $('#prbResistencia').append(label);


    objetoEjercicios = objeto[0].ListaPruebas;

    $.each(objetoEjercicios, function (i, item) {
        tr += '<tr>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Nombre + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Series + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Repeticiones + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Peso + '<br></td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Rm1 + '</td>';
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc1 + '</td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc2 + '</td>'
        tr += '<td class="tg-031e">' + objetoEjercicios[i].Prc3 + '</td>'
        tr += '</tr>'
    });
    $('#tblPruebas').append(tr);


}

function onSuccessTipoPrueba(result) {
    var objeto = $.parseJSON(result);
    var selectPrueba = "";
    selectPrueba += '<div class="form-group">';
    selectPrueba += '<label for="select13" class="col-sm-2 control-label">Tipo Prueba</label>';
    selectPrueba += '<div class="col-sm-10">';
    selectPrueba += '<select id="selectipoPrueba" name="select13" class="form-control">';
    selectPrueba += '<option value="">&nbsp;</option>';
    $.each(objeto, function (i, item) {
        selectPrueba += '<option value="' + objeto[i].Id + '">' + objeto[i].Nombre + '</option>'
    });
    selectPrueba += '</select><div class="form-control-line"></div>';
    selectPrueba += '</div>';
    selectPrueba += '</div>';
    $('#PruebasForm').append(selectPrueba);
    //$('#divMostrarHuesos').removeClass('ocultar');
    $("#selectipoPrueba").val(idTipoPrueba);
    load();
}

$('#btnAgregarPrueba').click(function () {
    window.location = "Agregar.aspx?Mode=Ins";
});

$('#AgregarEjercicios').click(function () {
    id = idTipoPrueba = $('#idPrueba').val();
    var resulId = getParameterByName("id");
    window.location = "../PruebaEjercicios/Agregar.aspx?id=" + id + "&Mode=Ins&idUser=" + resulId;
});

$('#btnCancelar').click(function () {
    var resulId = getParameterByName("id");
    window.location = "PruebaResistencia.aspx?id=" + resulId;
});

$('#btnGuardar').click(function () {

    var peso = $('#peso').val(),
    idTipoPrueba = $('#selectipoPrueba').val();
    idPrueba = $('#idPrueba').val();
    var datos = JSON.stringify({ pId: idPrueba, ppeso: peso, pidTipoPrueba: idTipoPrueba });
    servicePruebas.ModificarPrueba(datos, onSuccesModificar, errorMessage, null, null);
});

function onSuccesModificar(result) {
    alert('Se modifico correctamente la prueba');
    //window.location.reload();
    var resulId = getParameterByName("id");
    window.location = "PruebaResistencia.aspx?id=" + resulId;
}

function errorMessage(resul) {
    alert(resul.get_message());
}


$('#EliminarEjejrcicios').click(function () {
    var resulId = getParameterByName("id");
    var rows = $('tr.selected');
    var table = $('#tblPruebas').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][0];
    var datos = JSON.stringify({ pId: id });
    servicePruebas.EliminarPrueba(datos, onSuccesEliminar, errorMessage, null, null);
    //window.location = "Modificar.aspx?id=" + resulId + "&Mode=Upd"
});

function onSuccesEliminar(result) {
    alert('Se elimino correctamente la prueba');
    //window.location.reload();
    //var resulId = getParameterByName("id");
    //window.location = "PruebaResistencia.aspx?id=" + resulId;
}

$('#btnModificarPruebaResistencia').click(function () {
    var resulId = getParameterByName("id");
    window.location = "Modificar.aspx?id=" + resulId + "&Mode=Upd"
});

function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

function load() {
    var table = $('#tblPruebas').DataTable({
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
                "previous": '<i class="fa fa-angle-left"></i>',
                "next": '<i class="fa fa-angle-right"></i>'
            }
        }
    });

    $('#tblPruebas tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}