
function ingresarTipoDePago() {

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
    var repetirContrasena = $('#txtRepetirContrasena').val();

    var servicio = new ServicioEnClases.ServicioUsuario();
    



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
        pContrasena: contrasena
    });
    var respuesta = servicio.InsertarUsuario(datos, onSuccesIngresar, errorMessage, null, null);
    
    var object = $.parseJSON(respuesta);
}

