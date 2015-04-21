/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/InsertarEjercicio.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
function load() {
    var table = $('#tblEjercicios').DataTable({
        "dom": 'lCfrtip',
        "order": [],
        "colVis": {
            "buttonText": "Columnas",
            "overlayFade": 0,
            "align": "right"
        },
        "language": {
            "lengthMenu": '_MENU_ entradas por página',
            "search": '<i class="fa fa-search"></i>',
            "paginate": {
                "previous": '<i class="fa fa-angle-left"></i>',
                "next": '<i class="fa fa-angle-right"></i>'
            }
        }
    });
    $('#tblEjercicios tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}
function buscarEjericicio() {
    var service1 = new ServicioEjercicio();
    service1.obtenerEjercicios(onSuccess, null, null);
}
function onSuccess(result) {
    var object = $.parseJSON(result);
    var tbody = "";
    $.each(object, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + object[i].Id + '</td>';
        tbody += '<td>' + object[i].Nombre + '</td>';
        tbody += '<td>' + object[i].Alias + ' ' + object[i].Apellido + '</td>';
        tbody += '<td>' + object[i].PosicionInicial + '</td>';
        tbody += '<td>' + object[i].PosicionFinal + '</td>';
        tbody += '<td>' + object[i].ErroresComunes + '</td>';
        tbody += '<td>' + object[i].Descripcion + '</td>';
        tbody += '</tr>';
    });
    $('#tblEjercicios tbody').append(tbody);
    load();
};
function buscarMusculos() {
    var service2 = new ServicioEnClases.ServicioProyecto();
    service2.obtenerMusculos(onSuccessMusculos, null, null);
}

function onSuccessMusculos(result) {
    var objeto = $.parseJSON(result);
    var Ulist = "";

    $.each(objeto, function (i, item) {
        Ulist += '<li>';
        Ulist += '<label>';
        Ulist += '<input name="chkboxName" type="checkbox" value ="' + objeto[i].Id + '">';
        Ulist += '<span>' + objeto[i].Nombre + '</span>';
        Ulist += '</label>';
        Ulist += '</li>';
    });
    $('#listaMusculosSecundarios').append(Ulist);

    $.each(objeto, function (i, item) {
        $("#musculo-principal").append("<option value=\"" + objeto[i].Id + "\">" + objeto[i].Nombre + "</option>");
    });

}
$('#fotoFile').change(function handleFileSelect(evt) {
    var input = evt.target;

    var reader = new FileReader();
    reader.onload = function () {
        var dataURL = reader.result;
        var output = document.getElementById('myImagen');
        output.src = dataURL;

        var canvas = document.getElementById('myCanvas');
        canvas.width = output.width;
        canvas.height = output.height;

        $('#myImagen').css('maxWidth', 150);
    };
    reader.readAsDataURL(input.files[0]);
});
$('#fotoFile2').change(function handleFileSelect(evt) {
    var input = evt.target;

    var reader = new FileReader();
    reader.onload = function () {
        var dataURL = reader.result;
        var output = document.getElementById('myImagen2');
        output.src = dataURL;

        var canvas = document.getElementById('myCanvas2');
        canvas.width = output.width;
        canvas.height = output.height;

        $('#myImagen2').css('maxWidth', 150);
    };
    reader.readAsDataURL(input.files[0]);
})

$('#btnAgregarEjercicio').click(function () {
   
    var nombre = $('#txtnombreEjercicio').val(),
        alias = $('#alias').val(),
        descripcion = $('#descripcion').val(),
        erroresComunes = $('#erroresComunes').val(),
        posInicial = $('#txtPosInicial').val(),
        posFinal = $('#txtPosFinal').val(),
        musculoPrincipal = $('#musculo-principal').val(),
        musculosSecundarios = $("input[name=chkboxName]:checked").map(function () { return this.value; }).get().join(",");

    var foto = getBase64Image();
    var foto2 = getBase64Image2();


    service4 = new ServicioEjercicio();
  
    var datos = JSON.stringify({pnombre: nombre, palias: alias, pdescripcion: descripcion, perroresComunes: erroresComunes, pposInicial: posInicial, pposFinal: posFinal,pmusculoPrincipal: musculoPrincipal, pmusculosSecundarios: musculosSecundarios, pimagen: foto , pimagen2 :foto2});
    service4.insertarEjercicio(datos, onSuccesIngresar, errorMessage, null, null);

    //        ;

    //var foto = getBase64Image();
    //console.log(foto);

    //serviceInsertar = new ServicioEnClases.ServiciosTiposDeMaquinas();

    //datos = JSON.stringify({ pnombre: nombre, pdescripcion: descripcion, pfoto: foto });
    //serviceInsertar.insertarTiposDeMaquina(datos, onSuccesIngresarTipoDeMaquina, errorMessage, null, null);

        //    $.ajax({
        //        type: 'POST',
        //        url: 'ServiciosTiposDeMaquinas.svc/insertarTiposDeMaquina',
        //        data: '{ "pfoto" : "' + foto + '", "pnombre" : "' + nombre + '", "pdescripcion" : "' + descripcion +'"}',
        //        contentType: 'application/json; charset=utf-8',
        //        dataType: 'json',
        //        success: function (msg) {
        //            alert("Done, Picture Uploaded.");
        //        }
        //    })

})

function onSuccesIngresar(result) {
    alert("congratulations");
}
function errorMessage(result) {
    alert("error  : " + result.responseText);
}
function getBase64Image() {

    var canvas = document.getElementById('myCanvas');
    var imagen = document.getElementById('myImagen');

    canvas.width = imagen.width;
    canvas.height = imagen.height;

    var ctx = canvas.getContext('2d');
    ctx.drawImage(imagen, 0, 0);

    //$('#myCanvas').css('maxWidth', 150);

    var dataURL = canvas.toDataURL();

    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");
}

function getBase64Image2() {

    var canvas = document.getElementById('myCanvas2');
    var imagen = document.getElementById('myImagen2');

    canvas.width = imagen.width;
    canvas.height = imagen.height;

    var ctx = canvas.getContext('2d');
    ctx.drawImage(imagen, 0, 0);

    //$('#myCanvas').css('maxWidth', 150);

    var dataURL = canvas.toDataURL();

    return dataURL.replace(/^data:image\/(png|jpg);base64,/, "");
}
$('#btnModificarEjer').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblEjercicios').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];
    alert(id);
    location.href = "ModificarEjercicio.aspx?id="+id;
})

function buscarEjercicioByID() {
    var service1 = new ServicioEjercicio();
    service1.obtenerEjercicioByID(onSuccess, null, null);
}

$('#btnAgregarEjer').click(function () {
    location.href = "InsertarEjercicio.aspx";
})
