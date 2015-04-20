$('#fotoFile').change(function handleFileSelect(evt) {
    var input = evt.target;

    var reader = new FileReader();
    reader.onload = function () {
        var dataURL = reader.result;
        var output = document.getElementById('foto');
        output.src = dataURL;
    };
    reader.readAsDataURL(input.files[0]);
})

$('#btnAgregarTipoDeMaquina').click(function () {
    var nombre = $('#txtNombreTipoDeMaquina').val(),
        descripcion = $('#txtDescripcion').val(),
        fotoUrl = $('#foto');

    var foto = getBase64Image();

    alert(foto);

    //serviceInsertar = new ServicioEnClases.ServiciosTiposDeMaquinas();

    //datos = JSON.stringify({ pnombre: nombre, pdescripcion: descripcion, pfoto: foto });
    //serviceInsertar.insertarTiposDeMaquina(datos, onSuccesIngresarTipoDeMaquina, errorMessage, null, null);
})

function getBase64Image() {

    var canvas = document.getElementById('myCanvas');
    var imagen = document.getElementById('myImagen');
    canvas.width = imagen.width;
    canvas.height = imagen.height;

    var ctx = canvas.getContext("2d");
    ctx.drawImage(imagen, 0, 0);

    var dataURL = canvas.toDataURL();

    console.log( dataURL.replace(/^data:image\/(png|jpg);base64,/, ""));
    
}

function onSuccesIngresarTipoDeMaquina(result) {
    alert('Se registró correctamente el tipo de máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}
