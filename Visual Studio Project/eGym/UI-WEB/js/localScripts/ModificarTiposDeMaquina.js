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
        var nombre = $('#txtNombreTipoDeMaquina').val(),
            descripcion = $('#txtDescripcion').val(),
            fotoUrl = $('#foto');

        var foto = getBase64Image();

        serviceInsertar = new ServiciosTiposDeMaquinas();

        datos = JSON.stringify({ pnombre: nombre, pdescripcion: descripcion, pfoto: foto });
        serviceInsertar.insertarTiposDeMaquina(datos, onSuccesIngresarTipoDeMaquina, errorMessage, null, null);

        window.location = 'Index.aspx';
    }
})

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