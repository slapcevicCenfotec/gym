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
    service2.obtenerMusculos(onSuccessMusculos, null, null);
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
function submit()
{
    var nombre = $('#txtnombreMusculo').val(),
         ubicacion = $('#txtubicacionMusculo').val(),
         origen = $('#txtorigenMusculo').val(),
         inserccion = $('#txtinserccionMusculo').val(),
         inervacion = $('#txtinervacionMusculo').val(),
         irrigacion = $('#txtirrigacionMusculo').val(),
        service4 = new ServicioEnClases.ServicioProyecto();

    var datos = JSON.stringify({ pnombre: nombre, pubicacion: ubicacion, porigen: origen, pinserccion: inserccion, pinervacion: inervacion, pirrigacion: irrigacion });
    service4.insertarMusculo(datos, onSuccesIngresar, null, null, null);

};
$('#btnAgregarMusculo').click(function () {
    location.href = "InsertarMusculo.aspx";
})
function onSuccesIngresar(result) {
    alert('Se registró correctamente el demonio');
}

$('#btnEliminarMus').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblMusculos').DataTable();

    var rowData = table.rows(rows).data();

    var id = rowData[0][0];

    var service3 = new ServicioEnClases.ServicioProyecto();

    var datos = JSON.stringify({ pid: id});

    service3.eliminarMusculo(datos, onSuccesEliminar, errorMessage, null);

})

function onSuccesEliminar (result)
{
    alert("Musculo fue eliminado");
}
function errorMessage(result) {
    alert("Error" + result);
}