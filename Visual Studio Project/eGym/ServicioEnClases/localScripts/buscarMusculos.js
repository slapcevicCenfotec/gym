var selected = [];
var table;

function buscarMusculos() {


    var service = new ServicioEnClases.ServicioProyecto();
    service.obtenerMusculos(onSuccessDioses, null, null);
}


function load() {
    //var el = document.getElementById("tblDioses");
    //el.addEventListener("click", function () { modificarMusculo($(this).find("td").eq(2).html()) }, false);

    table = $('#tblDioses').DataTable();

    $('#tblDioses tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}


function modificarMusculo() {
    
    var rows = $('tr.selected');
    var table = $('#tblDioses').DataTable();

    var rowData = table.rows(rows).data();
  
    var id = rowData[0][0];
    var nombre = rowData[0][1];
    var ubicacion = rowData[0][2];
    var origen = rowData[0][3];
    var inserccion = rowData[0][4];
    var inervacion = rowData[0][5];
    var irrigacion = rowData[0][6];
 
    var service2 = new ServicioEnClases.ServicioProyecto();

    var datos = JSON.stringify({ pid: id, ppnombre: "prueba 5" ,pubicacion:ubicacion,porigen:origen,pinserccion:inserccion,pinervacion:inervacion,pirrigacion:irrigacion});

    service2.modificarMusculo(datos, onSuccesModificar, errorMessage, null);

}

function eliminarMusculo() {
    var rows = $('tr.selected');
    var table = $('#tblDioses').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];
    
    var service3 = new ServicioEnClases.ServicioProyecto();

    var datos = JSON.stringify({ pid : id });

    service3.eliminarMusculo(datos, onSuccesEliminar, errorMessage, null);

}

function ingresarMusculo() {

    var nombre ='ppp',
        alias = 'ppp',
        descripcion = 'ppp',
        erroresComunes = 'ppp',
        posInicial = 'ppp',
        posFinal = 'ppp',
        musculoPrincipal = '1',
        musculosSecundarios = '1,2';

        var foto = '';
        var foto2 = '';


    service4 = new ServicioEjercicio();

    var datos = JSON.stringify({ pnombre: nombre, palias: alias, pdescripcion: descripcion, perroresComunes: erroresComunes, pposInicial: posInicial, pposFinal: posFinal, pmusculoPrincipal: musculoPrincipal, pmusculosSecundarios: musculosSecundarios, pimagen: foto, pimagen2: foto2
});
        service4.insertarEjercicio(datos, onSuccesIngresar, errorMessage, null, null);




   // var contrasena = 'danny';
   // var correo = 'dannye629@gmail.com';
   // var serviceLogin = new ServicioLogin.ServicioSesion();
   // datos = JSON.stringify({ pcontrasena: contrasena, pcorreo: correo });
   //serviceLogin.iniciarSesion(datos, onSuccess, errorMessage, null, null);


//       var id = '30'
//       usuario = '116',
//       tipo = '1',
//       titulo = 'Titulo',
//       descripcion = 'Desp',
//       fechaInicio = '2015-04-29T10:00:00',
//       fechaFinal = '2015-04-29T10:30:00'

//    var servicio2 = new ServicioEnClases.ServicioEventoCalendario();
//    var datos = JSON.stringify({ ID: id, USUARIO: usuario, TIPO: tipo, TITULO: titulo, DESCRIPCION: descripcion, FECHA_INICIAL: fechaInicio, FECHA_FINAL: fechaFinal
//    });

//servicio2.modificarEventoCalendario(datos, onsucessInsertar, onFailInsetar, null);


    //var nombre ="",
    //     ubicacion = "",
    //     origen = "",
    //     inserccion = "",
    //     inervacion = "",
    //     irrigacion = "",

    //    service4 = new ServicioEnClases.ServicioProyecto();

    //var datos = JSON.stringify({ pnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion });
    //service4.insertarMusculo(datos, onSuccesIngresar, errorMessage, null, null);

    }

    function onSuccesIngresar(result) {
    alert("congratulations");
}
function errorMessage(result) {
    alert(result.get_message());
}


function onSuccess(result) {
    alert("Yupiii")
    //var object = $.parseJSON(result);
    //if (result !== 'null') {
    //    console.log(object.Id);
    //    $.ajax({
    //type: "POST",
    //    url: "Session.aspx/SetUserId",
    //        data: '{ userId: "' + object.Id + '"}',
    //    contentType: "application/json; charset=utf-8",
    //    dataType: "json",
    //    success: onSuccessLogin
    //    });
    //    } else {
    //alert("Usuario invalido");
    //}
    }

function errorMessage(resul) {
        alert(resul.get_message());
    }


    function onsucessInsertar(result) {
                            alert("Yupiiii");
                            eventData = {
        title: titulo,
    start: fechaInicio,
    end: fechaFinal
                            };

                            $('#calendar').fullCalendar('renderEvent', eventData, true); // stick? = true

                        };
                        function onFailInsetar(result) {
                            alert(result.get_message());
                            $('#calendar').fullCalendar('unselect');
                        };
function onSuccesModificar(result) {
    alert('Se modificó correctamente el músculo');
}
function errorMessage(resul) {
    alert(resul.get_message());
}

function onSuccesIngresar(result) {
    alert('Se registró correctamente el demonio');
}
function onSuccesEliminar(result) {
    alert('Se eliminó correctamente el Musculo');
}


function onSuccessDioses(result) {
    var objeto = $.parseJSON(result);
    var tbody = "";
    $.each(objeto, function (i, item) {
        tbody += '<tr>';
        tbody += '<td>' + objeto[i].Identificacion + '</td>';
        tbody += '<td>' + objeto[i].Nombre + '</td>';
        tbody += '<td>' + objeto[i].Ubicacion + '</td>';
        tbody += '<td>' + objeto[i].Origen + '</td>';
        tbody += '<td>' + objeto[i].Inserccion + '</td>';
        tbody += '<td>' + objeto[i].Inervacion + '</td>';
        tbody += '<td>' + objeto[i].Irrigacion + '</td>';

        tbody += '</tr>';
    });
    $('#tblDioses tbody').append(tbody);
    load();
    //$('#divMostrarHuesos').removeClass('ocultar');
}