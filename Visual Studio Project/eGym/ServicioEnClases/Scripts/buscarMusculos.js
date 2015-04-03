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

    //var datos = JSON.stringify({ pid: id});

    service3.eliminarMusculo(id, onSuccesEliminar, errorMessage, null);

}
function ingresarMusculo() {
    var nombre = $('#txtnombreMusculo').val(),
         ubicacion = $('#txtubicacionMusculo').val(),
         origen = $('#txtorigenMusculo').val(),
         inserccion = $('#txtinserccionMusculo').val(),
         inervacion = $('#txtinervacionMusculo').val(),
         irrigacion = $('#txtirrigacionMusculo').val(),
        service4 = new ServicioEnClases.ServicioProyecto();

    var datos = JSON.stringify({ pnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion });
    service4.insertarMusculo(datos, onSuccesIngresar, errorMessage, null, null);

}

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
        tbody += '<td>' + objeto[i].Id + '</td>';
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