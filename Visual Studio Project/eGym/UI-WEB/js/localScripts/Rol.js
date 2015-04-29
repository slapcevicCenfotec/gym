var selected = [];
var table;
var serviceRol = new ServicioEnClases.ServicioRol();
var objetoPermisos;
var idRol;

$(document).ready(function () {

    var resulId = getParameterByName("id");
    var resulMode = getParameterByName("Mode");
    if (resulMode === "") {
        serviceRol.obtenerRoles(onSuccessRoles, null, null);
    }else if(resulMode === "Ins"){
        servicePermiso.obtenerPermiso(onSuccessPermisos, null, null);
    }else if(resulMode === "Upd"){
        var datos = JSON.stringify({ pid: resulId});
        serviceRol.obtenerRolPorPermiso(datos, onSuccessRolesPorId, errorMessage, null, null);
    }
});

$('#btnModificarRol').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblRoles').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][0];
    var cells = table.cells().nodes();
    window.location = "Modificar.aspx?id=" + id + "&Mode=Upd";
});

$('#btnCancelar').click(function () {
    window.location = "index.aspx";
});

$('#btnAgregarRol').click(function () {
    window.location = "Agregar.aspx?Mode=Ins";
});




$('#btnEliminiarRol').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblRoles').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][0];
    var cells = table.cells().nodes();
    var datos = JSON.stringify({ pId: id});
    serviceRol.EliminarRoles(datos, onSuccesEliminar, errorMessage, null, null);
});


function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}


function load() {
    var table = $('#tblRoles').DataTable({
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

    $('#tblRoles tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}




function ingresarRol() {
    var cantPermisos = 0;
    var nombre = $('#nombre').val(),
        descripcion = $('#descripcion').val();
    //serviceRol = new ServicioEnClases.ServicioRol();
    $("#RolesForm").validate();
    if ($("#RolesForm").valid()) {
        var listaPermisos = [];
        $('#listaPermisos li input[type=checkbox]').each(function () {
            if (this.checked === true) {
                var idPermiso = this.id;
                listaPermisos.push(idPermiso);
            }
        });
        var datos = JSON.stringify({ pnombre: nombre, pdescripcion: descripcion, ppermisos: listaPermisos });
        serviceRol.insertarRoles(datos, onSuccesIngresar, errorMessage, null, null);
    } 


}

function ActualizarRol() {
    var cantPermisos = 0;
        nombre = $('#nombre').val(),
        descripcion = $('#descripcion').val();
    //serviceRol = new ServicioEnClases.ServicioRol();
    var listaPermisos = [];
    $('#listaPermisos li input[type=checkbox]').each(function () {
        if (this.checked === true) {
            var idPermiso = this.id;
            listaPermisos.push(idPermiso);
        }
    });
    var datos = JSON.stringify({ pId:idRol,pnombre: nombre, pdescripcion: descripcion, ppermisos: listaPermisos });
    serviceRol.ModificarRoles(datos, onSuccesModificar, errorMessage, null, null);

}

function onSuccesIngresar(result) {
    alert('Se registró correctamente el Rol');
}

function onSuccesModificar(result) {
    alert('Se modificao correctamente el Rol');
}

function onSuccesEliminar(result) {
    alert('Se elimino correctamente el Rol');
    $('#tblRoles').dataTable().fnClearTable();
    serviceRol.obtenerRoles(onSuccessRoles, null, null);
}

function errorMessage(resul) {
    alert(resul.get_message());
}


function onSuccessRoles(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Nombre + '</td>';
        tbody += '<td>' + objeto[i].Descripcion + '</td>';
        tbody += '</tr>';
    });
    $('#tblRoles tbody').append(tbody);
    load();
}

function onSuccessRolesPorId(result) {
    var objeto = $.parseJSON(result);
    var input = "";
    $.each(objeto, function (i, item) {
        idRol = objeto[i].Id;
        input += '<div class="form-group">';
        input += '<label for="nombre" class="col-sm-2 control-label">Nombre</label>';
        input += '<div class="col-sm-10">';
        input += '<input type="text" class="form-control" id="nombre" value="' + objeto[i].Nombre + '">';
        input += '</div>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<label for="descripcion" class="col-sm-2 control-label">Descripcion</label>';
        input += '<div class="col-sm-10">';
        input += '<input type="text" class="form-control" id="descripcion" value="' + +objeto[i].Descripcion + '">';
        input += '</div>';
        input += '</div>';

    });
    $('#RolesForm').append(input);

     objetoPermisos =  objeto[0].ListaPermisos;


     servicePermiso.obtenerPermiso(onSuccessPermisos, null, null);
    //SelecionarPermisos(result);
    //load();
    //$('#divMostrarHuesos').removeClass('ocultar');
}


