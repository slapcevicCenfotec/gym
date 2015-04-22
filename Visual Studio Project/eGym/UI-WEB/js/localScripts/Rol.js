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
        serviceRol.obtenerRolPorId(datos, onSuccessRolesPorId, errorMessage, null, null);
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

$('#Cancelar').click(function () {
    window.location = "FrmListarRolesWeb.aspx";
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
    //var el = document.getElementById("tblDioses");frfrfrf
    //el.addEventListener("click", function () { modificarMusculo($(this).find("td").eq(2).html()) }, false);

    table = $('#tblRoles').DataTable();

    var id = table.row('.selected');

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
    //$('#divMostrarHuesos').removeClass('ocultar');
}

function onSuccessRolesPorId(result) {
    var objeto = $.parseJSON(result);
    var input = "";
    $.each(objeto, function (i, item) {
        idRol = objeto[i].Id;
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="nombre" value="' + objeto[i].Nombre + '">';
        input += '<label for="nombre">Nombre</label>';
        input += '</div>';
        input += '<div class="form-group">';
        input += '<input type="text" class="form-control" id="descripcion" value="' + objeto[i].Descripcion + '">';
        input += '<label for="descripcion">Descripcion</label>';
        input += '</div>';
    });
    $('#form1').append(input);

     objetoPermisos =  objeto[0].ListaPermisos;


     servicePermiso.obtenerPermiso(onSuccessPermisos, null, null);
    //SelecionarPermisos(result);
    //load();
    //$('#divMostrarHuesos').removeClass('ocultar');
}


