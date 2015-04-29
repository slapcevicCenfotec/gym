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
        tbody += '<td>' + object[i].Alias + '</td>';
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
        Ulist += '<input name="chkboxName" type="checkbox" value ="' + objeto[i].Id + '" id ="' + objeto[i].Id + '">';
        Ulist += '<span>' + objeto[i].Nombre + '</span>';
        Ulist += '</label>';
        Ulist += '</li>';
    });
    $('#listaMusculosSecundarios').append(Ulist);

    $.each(objeto, function (i, item) {
        $("#musculo_principal").append("<option value=\"" + objeto[i].Id + "\">" + objeto[i].Nombre + "</option>");

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

    $('frmInsertarEjercicio').validate({
        messages: {
            name: {
                required: "Campo es requerido"
            },
            alias: {
                required: "Campo es requerido"
            },
            descripcion: {
                required: "Campo es requerido"
            },
            erroresComunes: {
                required: "Campo es requerido"
            },
            txtPosInicial: {
                required: "Campo es requerido"
            },
            txtPosFinal: {
                required: "Campo es requerido"
            },
            musculo_principal: {
                required: "Campo es requerido"
            }
        }
    });

    if ($("#frmInsertarEjercicio").valid()) {

        var nombre = $('#txtnombreEjercicio').val(),
        alias = $('#alias').val(),
        descripcion = $('#descripcion').val(),
        erroresComunes = $('#erroresComunes').val(),
        posInicial = $('#txtPosInicial').val(),
        posFinal = $('#txtPosFinal').val(),
        musculoPrincipal = $('#musculo_principal').val(),
        musculosSecundarios = $("input[name=chkboxName]:checked").map(function () { return this.value; }).get().join(",");

        var foto = getBase64Image();
        var foto2 = getBase64Image2();

        service4 = new ServicioEjercicio();

        var datos = JSON.stringify({ pnombre: nombre, palias: alias, pdescripcion: descripcion, perroresComunes: erroresComunes, pposInicial: posInicial, pposFinal: posFinal, pmusculoPrincipal: musculoPrincipal, pmusculosSecundarios: musculosSecundarios, pimagen: foto, pimagen2: foto2 });
        service4.insertarEjercicio(datos, onSuccesIngresar, onFailModificar, null, null);
    }

})

function onSuccesIngresar(result) {
    location.href = "index.aspx?agregado";
    //alert("Ejericio agregado");
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
    location.href = "modificar.aspx?id=" + id;
})

function buscarEjercicioByID() {
    var service1 = new ServicioEjercicio();
    service1.obtenerEjercicioByID(onSuccess, null, null);
}

$('#btnAgregarEjer').click(function () {
    location.href = "InsertarEjercicio.aspx";
})
$('#btnEliminarEjer').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblEjercicios').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];
    var service4 = new ServicioEjercicio();

    var datos = JSON.stringify({ pid: id });
    service4.eliminarEjercicio(datos, onSucessEli, onFailEli, null, null);

    window.location = 'Index.aspx';
})
function onSucessEli(result) {
    toastr.success('El ejercicio ha sido eliminado')
    //alert("Ejercicio Eliminado");
}
function onFailEli(result) {
    toastr.error('El ejercicio no ha podido ser eliminado')
    //alert("Ejercicio Eliminado");
}
$('#btnModificarEjercicio').click(function () {
    $('frmModificarEjercicio').validate({
        messages: {
            name: {
                required: "Campo es requerido"
            },
            alias: {
                required: "Campo es requerido"
            },
            descripcion: {
                required: "Campo es requerido"
            },
            erroresComunes: {
                required: "Campo es requerido"
            },
            txtPosInicial: {
                required: "Campo es requerido"
            },
            txtPosFinal: {
                required: "Campo es requerido"
            },
            musculo_principal: {
                required: "Campo es requerido"
            }
        }
    });

    if ($("#frmModificarEjercicio").valid()) {
        //alert($('#txtIdEjercicio').val());
        var id = $('#txtIdEjercicio').val(),
        nombre = $('#txtnombreEjercicio').val(),
        alias = $('#alias').val(),
        descripcion = $('#descripcion').val(),
        erroresComunes = $('#erroresComunes').val(),
        posInicial = $('#txtPosInicial').val(),
        posFinal = $('#txtPosFinal').val(),
        musculoPrincipal = $('#musculo_principal').val(),
        musculosSecundarios = $("input[name=chkboxName]:checked").map(function () { return this.value; }).get().join(",");
        getBase64Image()
        getBase64Image2()
        var foto = '';
        var foto2 = '';

        //alert("Muscul principal" +musculoPrincipal);
        //alert("Muscul Secundario " +musculosSecundarios)


        service4 = new ServicioEjercicio();

        var datos = JSON.stringify({ pid: id, pnombre: nombre, palias: alias, pdescripcion: descripcion, perroresComunes: erroresComunes, pposInicial: posInicial, pposFinal: posFinal, pmusculoPrincipal: musculoPrincipal, pmusculosSecundarios: musculosSecundarios, pimagen: foto, pimagen2: foto2 });
        service4.modificarEjercicio(datos, onSuccesModificar, onFailModificar, null, null);
    }
});

$('#imagen').change(function () {
    readURL(this);
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
$('#imagen2').change(function () {
    readURL(this);
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#imgFoto2').attr('src', e.target.result).fadeIn('slow');

        }

        reader.readAsDataURL(input.files[0]);
    }

    var canvas = document.getElementById("myCanvas2");
    canvas.hidden = true;
}

function onSuccesModificar(result) {
    location.href = "index.aspx?modificado";
    //alert("Se modificó");
}
function onFailModificar(result) {
    location.href = "index.aspx?modificado";
    //alert(result.get_message());

}

$('#btnCancelarEjercicio').click(function () {
    $("#frmInsertarEjercicio").trigger('reset');
    window.location = 'index.aspx';
})

$('#btnCancelarEjercicioM').click(function () {
    $("#frmModificarEjercicio").trigger('reset');
    window.location = 'index.aspx';
})
