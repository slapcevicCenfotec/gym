$(document).ready(function () {

    var idUsuario = getQueryVariable('id');

    var servicioBuscarUsuario = new ServicioEnClases.ServicioUsuario();
    servicioBuscarUsuario.ObtenerUsuario(idUsuario, onSuccessObtenerUsuario, null, null);
});

function onSuccessObtenerUsuario(result){
    console.log(result);
    var objeto = $.parseJSON(result);

    $('#txtIdentificacion').val(objeto['Identificacion']);
    $('#txtTipoIdentificacion option:selected').val(objeto['IdTipoIdentificacion']);
    $('#txtPrimerNombre').val(objeto['Nombre']);
    $('#txtSegundoNombre').val(objeto['SegundoNombre']);
    $('#txtPrimerApellido').val(objeto['Apellido']);
    $('#txtSegundoApellido').val(objeto['SegundoApellido']);
    $('#txtAlias').val(objeto['Alias']);
    $('#txtGenero option:selected').val(objeto['IdGenero']);
    $('#txtFechaNacimiento').val(objeto['FechaNacimiento']);
    $('#txtCorreoElectronico').val(objeto['CorreoElectronico']);
    $('#txtNumeroTelefono').val(objeto['NumeroTelefono']);
    $('#txtNumeroCelular').val(objeto['NumeroCelular']);
    $('#imgFoto').val(objeto['Fotografia']);
    $('#txtRol option:selected').val(objeto['NumeroActivo']);
    $('#txtContrasena').val(objeto['Contrasena']);
    $('#txtRepetirContrasena').val(objeto['NumeroActivo']);

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

    $("#cmbTiposDeMaquinas option[value=" + objeto.TipoDeMaquina + "]").attr("selected", true);

    $('#idMaquina').val(objeto['Id']);
    $('#habilitado').val(objeto['Habilitado']);
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