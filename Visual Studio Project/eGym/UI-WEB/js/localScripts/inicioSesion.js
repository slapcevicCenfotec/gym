﻿$('#bntIniciarSesion').click(function () {
    var userId = $('#txtCorreo').val

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
    var object = $.parseJSON(result);
    console.log(object.Id);
    if (result !== 'null') {
        $.ajax({
            type: "POST",
            url: "Session.aspx/SetUserId",
            data: '{ userId: "' + object.Id + '"}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: onSuccessLogin
        });
    } else {
        alert("Usuario invalido");
    }
}

function errorMessage(resul) {
    console.log(resul);
}

function validateEmail(email) {
    var re = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
    return re.test(email);
}

function onSuccessLogin(result) {
    location.reload();
    location.reload();
}