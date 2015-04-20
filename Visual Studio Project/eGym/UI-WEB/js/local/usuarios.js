function load() {
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
    service.ObtenerUsuarios(onSuccess, null, null);
}

function error(result) {
    alert(result);
}

function onSuccess(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        tbody += '<tr>';
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


    $("#formulario").validate( {
        rules: {
            identificacion: {
                required: true
            }
        }, messages: {
            identificacion: {
                required: "HEY!"
            }
        }, submitHandler: function (form) {
            alert("formulario validado");
            submit();
        }, highlight: function (element, errorClass) {
            $(element).closest('.form-group').addClass('has-error');
        }, unhighlight: function (element, errorClass) {
            $(element).closest('.form-group').removeClass('has-error');
        }, errorPlacement: function (error, element) {
            if (element.attr('type') == 'checkbox') {
                element.closest('.form-group').children(0).prepend(error)
            } else {
                error.insertAfter(element);
            }
            error.appendTo(element.parent().next());
        }
    });


    //var identificacion = $('#txtIdentificacion').val();
    //var tipoIdentificacion = $('#txtTipoIdentificacion').val();
    //var primerNombre = $('#txtPrimerNombre').val();
    //var segundoNombre = $('#txtSegundoNombre').val();
    //var primerApellido = $('#txtPrimerApellido').val();
    //var segundoApellido = $('#txtSegundoApellido').val();
    //var alias = $('#txtAlias').val();
    //var genero = $('#txtGenero').val();
    //var fechaNacimiento = $('#txtFechaNacimiento').val();
    //var correoElectronico = $('#txtCorreoElectronico').val();
    //var numeroTelefono = $('#txtNumeroTelefono').val();
    //var numeroCelular = $('#txtNumeroCelular').val();
    //var rol = $('#txtRol').val();
    //var contrasena = $('#txtContrasena').val();
    //var imagen = $('#imgFoto').attr('src');
    //var repetirContrasena = $('#txtRepetirContrasena').val();

    //var servicio = new ServicioEnClases.ServicioUsuario();

    //var datos = JSON.stringify({
    //    pIdentificacion: identificacion,
    //    pTipoIdentificacion: tipoIdentificacion,
    //    pPrimerNombre: primerNombre,
    //    pSegundoNombre: segundoNombre,
    //    pSegundoApellido: segundoApellido,
    //    pPrimerApellido: primerApellido,
    //    pAlias: alias,
    //    pIdGenero: genero,
    //    pFechaNacimiento: fechaNacimiento,
    //    pCorreoElectronico: correoElectronico,
    //    pNumeroTelefono: numeroTelefono,
    //    pNumeroCelular: numeroCelular,
    //    pIdRol: rol,
    //    pContrasena: contrasena,
    //    pFoto: imagen
    //});
    //var respuesta = servicio.InsertarUsuario(datos, onSuccesIngresar, errorMessage, null, null);

    //var object = $.parseJSON(respuesta);
}

function onSuccesIngresar(result) {
    alert(result);
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