$(document).ready(function () {

    var idUsuario = getQueryVariable('id');

    var servicioBuscarUsuario = new ServicioEnClases.ServicioUsuario();
    servicioBuscarUsuario.ObtenerUsuario(idUsuario, onSuccessObtenerUsuario, null, null);


    var service = new ServicioEnClases.ServicioUsuario();
    service.ObtenerRoles(onSuccesRoles, null, null);

    function onSuccesRoles(result) {
        var objeto = $.parseJSON(result);
        $.each(objeto, function (i, item) {
            var option = $(document.createElement('option'));
            option.text(objeto[i].Nombre).val();
            option.val(objeto[i].Id);
            $('#txtRol').append(option);
        });
    }
});

function onSuccessObtenerUsuario(result){
    console.log(result);
    var objeto = $.parseJSON(result);

    $('#txtIdentificacion').val(objeto['Identificacion']);
    $("#txtTipoIdentificacion option[value=" + objeto.IdTipoIdentificacion + "]").attr("selected", true);
    $('#txtPrimerNombre').val(objeto['Nombre']);
    $('#txtSegundoNombre').val(objeto['SegundoNombre']);
    $('#txtPrimerApellido').val(objeto['Apellido']);
    $('#txtSegundoApellido').val(objeto['SegundoApellido']);
    $('#txtAlias').val(objeto['Alias']);
    $("#txtGenero option[value=" + objeto.IdGenero + "]").attr("selected", true);
    $('#txtFechaNacimiento').val(parseJsonDate(objeto['FechaNacimiento']));
    $('#txtCorreoElectronico').val(objeto['CorreoElectronico']);
    $('#txtNumeroTelefono').val(objeto['NumeroTelefono']);
    $('#txtNumeroCelular').val(objeto['NumeroCelular']);
    $('#imgFoto').val(objeto['Fotografia']);
    $("#txtRol").text("Administrador");
    $('#txtContrasena').val(objeto['Contrasena']);
    $('#txtRepetirContrasena').val(objeto['Contrasena']);

    $('#txtNombreContacto1').val(objeto['NumeroActivo']);
    $('#txtParentescoContacto1').val(objeto['NumeroActivo']);
    $('#txtNumeroContacto1').val(objeto['NumeroActivo']);

    $('#txtNombreContacto2').val(objeto['NumeroActivo']);
    $('#txtParentescoContacto2').val(objeto['NumeroActivo']);
    $('#txtNumeroContacto2').val(objeto['NumeroActivo']);

    $('#txtLunes1').val(objeto['NumeroActivo']);
    $('#txtLunes2').val(objeto['NumeroActivo']);
    $('#txtMartes1').val(objeto['NumeroActivo']);
    $('#txtMartes2').val(objeto['NumeroActivo']);
    $('#txtMiercoles1').val(objeto['NumeroActivo']);
    $('#txtMiercoles2').val(objeto['NumeroActivo']);
    $('#txtJueves1').val(objeto['NumeroActivo']);
    $('#txtJueves2').val(objeto['NumeroActivo']);
    $('#txtViernes1').val(objeto['NumeroActivo']);
    $('#txtViernes2').val(objeto['NumeroActivo']);
    $('#txtSabado1').val(objeto['NumeroActivo']);
    $('#txtSabado2').val(objeto['NumeroActivo']);
    $('#txtDomingo1').val(objeto['NumeroActivo']);
    $('#txtDomingo2').val(objeto['NumeroActivo']);

}

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split('&');
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split('=');
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
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