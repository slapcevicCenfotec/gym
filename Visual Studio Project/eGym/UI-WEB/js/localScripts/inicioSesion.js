
$('#bntIniciarSesion').click(function () {
    var contrasena = $('#txtContrasena').val();
    var correo = $('#txtCorreo').val();

    if (validateEmail(correo)) {
        datos = JSON.stringify({ pcontrasena: contrasena, pcorreo: correo });
        serviceLogin = new ServicioLogin.ServicioSesion();
        serviceLogin.iniciarSesion(datos, onSuccess, errorMessage, null, null);
    } else {
        
    };
})

function onSuccess(result) {

    console.log(result);
    window.location.href = "http://localhost/egym/index.aspx";
}

function errorMessage(resul) {
    alert(resul.get_message());
}

function validateEmail(email) {
    var re = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
    return re.test(email);
}