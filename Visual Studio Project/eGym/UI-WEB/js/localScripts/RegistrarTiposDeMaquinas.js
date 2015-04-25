var hayFoto;

$(document).ready(function () {
    $('#imagen').change(function () {
        readURL(this);
    });
});

function readURL(input) {
    if(input.files && input.files[0]){
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#imgFoto').attr('src', e.target.result).fadeIn('slow');
        }

        reader.readAsDataURL(input.files[0]);
    }

    hayFoto = true;
}

$('#btnGuardar').click(function () {
    $("#tipoMaquinaForm").validate();

    if ($("#tipoMaquinaForm").valid() && hayFoto) {
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

function onSuccesIngresarTipoDeMaquina(result) {
    alert('Se registró correctamente el tipo de máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}

$('#btnCancelar').click(function () {
    $("#tipoMaquinaForm").trigger('reset');
    window.location = 'Index.aspx';
})
