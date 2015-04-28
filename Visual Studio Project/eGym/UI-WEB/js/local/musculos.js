/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Musculo/modificar.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Musculo/modificar.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Musculo/ModificarMusculo.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
/// <reference path="C:\Users\espindan\Documents\Cenfotec\Proyecto2\Segunda Iteracion\eGym2\gym\Visual Studio Project\eGym\UI-WEB\Ejercicios/ModificarEjercicio.aspx" />
function load() {
    var table = $('#tblMusculos').DataTable({
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
    $('#tblMusculos tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}

function buscarMusculos() {
    var service2 = new ServicioEnClases.ServicioProyecto();
    service2.obtenerMusculos(onSuccessMusculos, errorMessageListar, null);
}

function errorMessageListar(resul) {
    alert(resul.get_message());
}

function onSuccessMusculos(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";

    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + objeto[i].Id + '</td>';
        tbody += '<td>' + objeto[i].Nombre + '</td>';
        tbody += '<td>' + objeto[i].Ubicacion + '</td>';
        tbody += '<td>' + objeto[i].Origen + '</td>';
        tbody += '<td>' + objeto[i].Inserccion + '</td>';
        tbody += '<td>' + objeto[i].Inervacion + '</td>';
        tbody += '<td>' + objeto[i].Irrigacion + '</td>';

        tbody += '</tr>';
    });
    $('#tblMusculos tbody').append(tbody);
    load();
}
$('#btnAgregarMusculo').click(function () {

    $('frmIngresarMusculo').validate({
        messages: {
            name: {
                required: "Campo es requerido"
            },
            ubicacion: {
                required: "Campo es requerido"
            },
            origen: {
                required: "Campo es requerido"
            },
            insercccion: {
                required: "Campo es requerido"
            },
            inervacion: {
                required: "Campo es requerido"
            },
            irrigacion: {
                required: "Campo es requerido"
            }
        },
        //submitHandler: function (form) {
            
        //    //alert("formulario validado");
        //    //submit();
        //}
        //highlight: function (element, errorClass) {
        //    $(element).closest('.form-group').addClass('has-error');
        //},
        //unhighlight: function (element, errorClass) {
        //    $(element).closest('.form-group').removeClass('has-error');
        //},

        //errorPlacement: function (error, element) {

        //    if (element.attr('type') == 'checkbox') {
        //        element.closest('.form-group').children(0).prepend(error)
        //    }
        //    else
        //        error.insertAfter(element);

        //    error.appendTo(element.parent().next());
        //}
    });

    if ($("#frmIngresarMusculo").valid()) {
        var nombre = $('#txtnombreMusculo').val(),
            ubicacion = $('#txtubicacionMusculo').val(),
            origen = $('#txtorigenMusculo').val(),
            inserccion = $('#txtinserccionMusculo').val(),
            inervacion = $('#txtinervacionMusculo').val(),
            irrigacion = $('#txtirrigacionMusculo').val(),
        service4 = new ServicioEnClases.ServicioProyecto();

        var datos = JSON.stringify({ pnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion });
        service4.insertarMusculo(datos, onSuccesIngresar, onFailIngresar, null, null);
    }
});
$('#btnIrAgregarMusculo').click(function () {
    location.href = "agregar.aspx";
})
function onSuccesIngresar(result) {
    location.href = "index.aspx?agregado";
   // alert('Se registró correctamente el músculo');
}
function onFailIngresar(result) {
   toastr.error('El músculo no ha podido ser agregado');
}


$('#btnEliminarMus').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMusculos').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];

    var service5 = new ServicioEnClases.ServicioProyecto();
    var datos = JSON.stringify({ pid: id
});
    service5.eliminarMusculo(datos, onSuccesEliminar, onFailEliminar, null);

})

function onSuccesEliminar(result) {
    toastr.success('El músculo ha sido eliminado')
    //alert("Musculo fue eliminado");
    }
    function onFailEliminar(result) {
          toastr.error('El músculo no ha podido ser eliminado');

     //   alert("Error" +result);
        }
    $('#btnModificarMus').click(function () {
        var rows = $('tr.selected');
        var table = $('#tblMusculos').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];

    location.href = "modificar.aspx?id=" +id;
    })
$('#btnModificarMusculo').click(function () {

    $('#frmModificarMusculo').validate({
            messages: {
                name: {
                    required: "Campo es requerido"
            },
                    ubicacion: {
                            required: "Campo es requerido"
            },
                    origen: {
                            required: "Campo es requerido"
            },
                    insercccion: {
                            required: "Campo es requerido"
            },
                    inervacion: {
                            required: "Campo es requerido"
            },
                    irrigacion: {
                            required: "Campo es requerido"
            }
    }
});
if ($("#frmModificarMusculo").valid()) {
        var id = $('#txtIdMusculo').val(),
            nombre = $('#txtnombreMusculo').val(),
            ubicacion = $('#txtubicacionMusculo').val(),
            origen = $('#txtorigenMusculo').val(),
            inserccion = $('#txtinserccionMusculo').val(),
            inervacion = $('#txtinervacionMusculo').val(),
            irrigacion = $('#txtirrigacionMusculo').val()

        var service2 = new ServicioEnClases.ServicioProyecto();

        var datos = JSON.stringify({ pid: id, ppnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion
});

        service2.modificarMusculo(datos, onSuccesModificar, errorMessageModificar, null)
}
    //var id = $('#txtIdMusculo').val(),
    //    nombre = $('#txtnombreMusculo').val(),
    //    ubicacion = $('#txtubicacionMusculo').val(),
    //    origen = $('#txtorigenMusculo').val(),
    //    inserccion =  $('#txtinserccionMusculo').val(),
    //    inervacion =  $('#txtinervacionMusculo').val(),
    //    irrigacion = $('#txtirrigacionMusculo').val()

    //var service2 = new ServicioEnClases.ServicioProyecto();

    //var datos = JSON.stringify({ pid: id, ppnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion });

    //service2.modificarMusculo(datos, onSuccesModificar, errorMessageModificar, null)
});

    function onSuccesModificar(result) {
        location.href = "index.aspx?modificado";
         //alert('Se modificó correctamente el músculo');
    };
    function errorMessageModificar(resul) {
        toastr.error('El músculo no ha podido ser modificado');

 //       alert(resul.get_message());
}
