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
   var usuario = '116',
        tipo = '1',
      titulo = 'Titulo',
      descripcion = 'Desp',
      fechaInicio = '2015-04-29T10:00:00',
      fechaFinal = '2015-04-29T10:30:00'

    var servicio2 = new ServicioEnClases.ServicioEventoCalendario();
    var datos = JSON.stringify({ USUARIO: usuario, TIPO: tipo, TITULO: titulo, DESCRIPCION: descripcion, FECHA_INICIAL: fechaInicio, FECHA_FINAL: fechaFinal });

servicio2.insertarEventoCalendario(datos, onsucessInsertar, onFailInsetar, null);


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