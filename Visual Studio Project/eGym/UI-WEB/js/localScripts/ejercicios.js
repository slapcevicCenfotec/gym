
function buscarEjercicios()
{
    var servicio = new Prueba();
    //servicio.obtenerMaquinas(onSuccess, null, null);
    //servicio.obtenerEjercicios(onSuccess, null, null);
}
function onSuccess(result) {
    alert(result);
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + item + '</td>';

        tbody += '</tr>';
    });
    $('#tblDioses tbody').append(tbody);
    //$('#divMostrarHuesos').removeClass('ocultar');
};

function insertImage()
{
  
    alert("Insert image");

    imagen = getBase64Image();
    
    var datos = JSON.stringify({ pnombre: image });
    servicio4.insertImage(datos, onSuccesIngresar, errorMessage, null, nul);  
}

function getBase64Image() {

    var c = document.getElementById("myCanvas");
    //var img = document.getElementById("imagen1");
    //c.height = img.height;
    //c.width = img.width;
    //var ctx = c.getContext("2d");

    //ctx.drawImage(img, 0, 0);
    var dataURL = c.toDataURL();
    
    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");
}

