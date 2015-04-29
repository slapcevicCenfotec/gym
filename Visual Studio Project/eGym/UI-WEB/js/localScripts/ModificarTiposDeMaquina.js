$(document).ready(function () {
    $('#imagen').change(function () {
        readURL(this);
    });

    var idTipoMaquina = getQueryVariable('id');

    var serviceBuscarTipoMaquinaPorId = new ServiciosTiposDeMaquinas();
    serviceBuscarTipoMaquinaPorId.obtenerTipoDeMaquinaById(idTipoMaquina, onSuccessObtenerTipoMaquina, null, null);
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#imgFoto').attr('src', e.target.result).fadeIn('slow');

        }

        reader.readAsDataURL(input.files[0]);
    }

    var canvas = document.getElementById("myCanvas");
    canvas.hidden = true;
}

function onSuccessObtenerTipoMaquina(result) {
    var objeto = $.parseJSON(result);

    $('#txtNombreTipoDeMaquina').val(objeto['Nombre']);
    $('#txtDescripcion').val(objeto['Descripcion']);
    $('#txtIdTipoMaquina').val(objeto['Id']);
    $('#txtHabilitado').val(objeto['Habilitado']);

    drawImage(objeto['Foto']);
}

function drawImage(imgData) {
    "use strict";
    var canvas = document.getElementById("myCanvas");
    var ctx = canvas.getContext("2d");

    //var uInt8Array = new Uint8Array(imgData);
    var uInt8Array = imgData;
    var i = uInt8Array.length;
    var binaryString = [i];
    while (i--) {
        binaryString[i] = String.fromCharCode(uInt8Array[i]);
    }
    var data = binaryString.join('');

    var base64 = window.btoa(data);

    var img = new Image();
    img.src = "data:image/png;base64," + base64;
    canvas.width = img.width;
    canvas.height = img.height;
    img.onload = function () {
        ctx.drawImage(img, 0, 0, canvas.width, canvas.height);
    };
    img.onerror = function (stuff) {
        console.log("Img Onerror:", stuff);
    };

}

$('#btnGuardar').click(function () {
    $("#modificarTipoMaquinaForm").validate();

    if ($("#modificarTipoMaquinaForm").valid()) {
        var idTipoDeMaquina = $('#txtIdTipoMaquina').val(),
            nombre = $('#txtNombreTipoDeMaquina').val(),
            descripcion = $('#txtDescripcion').val(),
            habilitado = $('#txtHabilitado').val(),
            fotoUrl = $('#foto');

        var foto = getBase64Image();

        serviceInsertar = new ServiciosTiposDeMaquinas();

        datos = JSON.stringify({ pid: idTipoDeMaquina, pfoto: foto, pnombre: nombre, pdescripcion: descripcion, phabilitado: habilitado });
        console.log(datos);
        serviceInsertar.modificarTiposDeMaquina(datos, onSuccesModificarTipoDeMaquina, errorMessage, null, null);

        window.location = 'Index.aspx';
    }
})

function onSuccesModificarTipoDeMaquina(result) {
    alert('Se registró correctamente el tipo de máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}

function getBase64Image() {

    var canvas = document.getElementById('myCanvas');
    var imagen = document.getElementById('imgFoto');

    canvas.width = imagen.width;
    canvas.height = imagen.height;

    var ctx = canvas.getContext("2d");
    ctx.drawImage(imagen, 0, 0);

    var dataURL = canvas.toDataURL();

    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");

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

$('#btnCancelar').click(function () {
    $("#modificarTipoMaquinaForm").trigger('reset');
    window.location = 'Index.aspx';
})