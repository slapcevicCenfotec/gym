﻿function load() {
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
            "search": '<i class="fa fa-search"></i>',
            "paginate": {
                "previous": '<i class="fa fa-angle-left"></i>',
                "next": '<i class="fa fa-angle-right"></i>'
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

function search() {
    var service = new ServicioEnClases.ServicioUsuario();
    service.ObtenerUsuarios(onSuccess2, null, null);
}

function error(result) {
    alert(result);
}

function onSuccess2(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        tbody += '<tr>';
        tbody += '<td style="display:none"' + object[i].Id + '</td>';
        tbody += '<td>' + object[i].Identificacion + '</td>';
        tbody += '<td>' + object[i].Nombre + ' ' + object[i].Apellido + '</td>';
        tbody += '<td>' + object[i].Alias + '</td>';
        tbody += '<td>' + parseJsonDate(object[i].FechaIngreso) + '</td>';
        tbody += '</tr>';
    });
    $('#tblUsuarios tbody').append(tbody);

    load();
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

function ingresarUsuario() {

    // INSTANCIAR SERVICIO

    var servicio = new ServicioEnClases.ServicioUsuario();

    // INSERTAR USUARIO

    var identificacion = $('#txtIdentificacion').val();
    var tipoIdentificacion = $('#txtTipoIdentificacion').val();
    var primerNombre = $('#txtPrimerNombre').val();
    var segundoNombre = $('#txtSegundoNombre').val();
    var primerApellido = $('#txtPrimerApellido').val();
    var segundoApellido = $('#txtSegundoApellido').val();
    var alias = $('#txtAlias').val();
    var genero = $('#txtGenero').val();
    var fechaNacimiento = $('#txtFechaNacimiento').val();
    var correoElectronico = $('#txtCorreoElectronico').val();
    var numeroTelefono = $('#txtNumeroTelefono').val();
    var numeroCelular = $('#txtNumeroCelular').val();
    var rol = $('#txtRol').val();
    var contrasena = $('#txtContrasena').val();
    var imagen = $('#imgFoto').attr('src');
    var repetirContrasena = $('#txtRepetirContrasena').val();

    if (!imagen) {
        imagen = null;
    }

    var datos = JSON.stringify({
        pIdentificacion: identificacion,
        pTipoIdentificacion: tipoIdentificacion,
        pPrimerNombre: primerNombre,
        pSegundoNombre: segundoNombre,
        pSegundoApellido: segundoApellido,
        pPrimerApellido: primerApellido,
        pAlias: alias,
        pIdGenero: genero,
        pFechaNacimiento: fechaNacimiento,
        pCorreoElectronico: correoElectronico,
        pNumeroTelefono: numeroTelefono,
        pNumeroCelular: numeroCelular,
        pIdRol: rol,
        pContrasena: contrasena,
        pFoto: imagen
    });

    var respuesta = servicio.InsertarUsuario(datos, onSuccessIngresarUsuario, errorMessage, null, null);

    window.location = 'index.aspx';

}

function onSuccessIngresarUsuario(result) {

    // INSTANCIAR SERVICIO

    var servicio = new ServicioEnClases.ServicioUsuario();

    // INSERTAR CONTACTO #1 

    var nombreContacto1 = $('#txtNombreContacto1').val();
    var parentescoContacto1 = $('#txtParentescoContacto1').val();
    var numeroContacto1 = $('#txtNumeroContacto1').val();

    var datos = JSON.stringify({
        pNombre: nombreContacto1,
        pParentesco: parentescoContacto1,
        pNumero: numeroContacto1,
    });

    respuesta = servicio.InsertarContacto(datos, onSuccess, errorMessage, null, null);

    // INSERTAR CONTACTO #2

    var nombreContacto2 = $('#txtNombreContacto2').val();
    var parentescoContacto2 = $('#txtParentescoContacto2').val();
    var numeroContacto2 = $('#txtNumeroContacto2').val();

    if (nombreContacto2 && parentescoContacto2 && numeroContacto2) {

        datos = JSON.stringify({
            pNombre: nombreContacto2,
            pParentesco: parentescoContacto2,
            pNumero: numeroContacto2,
        });

        respuesta = servicio.InsertarContacto(datos, onSuccess, errorMessage, null, null);
    }

    // INSERTAR LUNES

    var lunes1 = $('#txtLunes1').val();
    var lunes2 = $('#txtLunes2').val();

    if (lunes1 && lunes2) {

        datos = JSON.stringify({
            pHoraEntrada: lunes1,
            pHoraSalida: lunes2,
            pDiaSemana: 1
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR MARTES

    var martes1 = $('#txtMartes1').val();
    var martes2 = $('#txtMartes2').val();

    if (martes1 && martes2) {

        datos = JSON.stringify({
            pHoraEntrada: martes1,
            pHoraSalida: martes2,
            pDiaSemana: 2
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR MIERCOLES

    var miercoles1 = $('#txtMiercoles1').val();
    var miercoles2 = $('#txtMiercoles2').val();

    if (miercoles1 && miercoles2) {

        datos = JSON.stringify({
            pHoraEntrada: miercoles1,
            pHoraSalida: miercoles2,
            pDiaSemana: 3
        });
null
respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR JUEVES

    var jueves1 = $('#txtJueves1').val();
    var jueves2 = $('#txtJueves2').val();

    if (jueves1 && jueves2) {

        datos = JSON.stringify({
            pHoraEntrada: jueves1,
            pHoraSalida: jueves2,
            pDiaSemana: 4
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR VIERNES

    var viernes1 = $('#txtViernes1').val();
    var viernes2 = $('#txtViernes2').val();

    if (viernes1 && viernes2) {

        datos = JSON.stringify({
            pHoraEntrada: viernes1,
            pHoraSalida: viernes2,
            pDiaSemana: 5
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR SABADO

    var sabado1 = $('#txtSabado1').val();
    var sabado2 = $('#txtSabado2').val();

    if (sabado1 && sabado2) {

        datos = JSON.stringify({
            pHoraEntrada: sabado1,
            pHoraSalida: sabado2,
            pDiaSemana: 6
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }

    // INSERTAR DOMINGO

    var domingo1 = $('#txtDomingo1').val();
    var domingo2 = $('#txtDomingo2').val();

    if (domingo1 && domingo2) {

        datos = JSON.stringify({
            pHoraEntrada: domingo1,
            pHoraSalida: domingo2,
            pDiaSemana: 0
        });

        respuesta = servicio.InsertarHorario(datos, null, errorMessage, null, null);
    }
}


function errorMessage(resul) {
    alert(resul.get_message());
}

function obtenerRoles() {
    var service = new ServicioEnClases.ServicioUsuario();
    service.ObtenerRoles(onSuccesRoles, null, null);
}

function onSuccesRoles(result) {
    var objeto = $.parseJSON(result);
    $.each(objeto, function (i, item) {
        var option = $(document.createElement('option'));
        option.text(objeto[i].Nombre).val();
        option.val(objeto[i].Id);
        $('#txtRol').append(option);
    });
}

function getClientes() {
    var datos = JSON.stringify({ pRol: 19 });
    servicio = new ServicioEnClases.ServicioUsuario();
    servicio.getUsuarioPorRol(datos, onSuccesGetClientes, null, null, null);
}


function onSuccesGetClientes(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";

    $.each(objeto, function (i, item) {
        tbody += "<div class='col-xs-12 col-lg-6 hbox-xs'>";
        tbody += "<div class='hbox-column width-2'>"
        tbody += "<img class='img-circle img-responsive pull-left' src='' alt=''>"
        tbody += "</div>"
                                        
        tbody += "<div class='hbox-column v-top'>"
        tbody += "<div class='clearfix'>"
        tbody += "<div class='col-lg-12 margin-bottom-lg'>"
        tbody += "<a class='text-lg text-medium' href=''>Ann Laurens</a>"
        tbody += "</div></div><div class='clearfix opacity-75'>"
        tbody += "<div class='col-md-5'>"
        tbody += "<span class='glyphicon glyphicon-phone text-sm'></span> &nbsp;567-890-1234"
        tbody += "</div><div class='col-md-7'>"
        tbody += "<span class='glyphicon glyphicon-envelope text-sm'></span> &nbsp;ann@laurens.com"
        tbody += "</div></div><div class='clearfix'><div class='col-lg-12'>"
        tbody += "<span class='opacity-75'><span class='glyphicon glyphicon-map-marker text-sm'></span> &nbsp;795 Folsom Ave, San Francisco, CA 94107</span>"
        tbody += "</div></div></div></div>";
    });
    $('#list-results').append(tbody);
}

//OCULTAR HORARIOS

$('#txtRol').change(function () {
    var rol = this.value;
    
    if (rol == 19) {
        $("#third").hide();

        document.getElementById("tabsMenu").children[2].style.display = "none";
    } else {
        $("#third").show();

        document.getElementById("tabsMenu").children[2].style.display = "block";

    }
});

//AGREGAR USUARIO

$('#btnAgregar').click(function () {
    window.location = 'agregar.aspx';
})

//MODIFICAR USUARIO


$('#btnModificar').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblUsuarios').DataTable();
    var rowData = table.rows(rows).data();
    var idUsuario = rowData[0][0];
    window.location = "modificar.aspx?id=" + idUsuario;
})

