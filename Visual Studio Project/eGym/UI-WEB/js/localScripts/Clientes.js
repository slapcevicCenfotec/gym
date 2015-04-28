
$('#btnPruebaResistencia').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblUsuarios').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][1];
    var cells = table.cells().nodes();
    var datos = JSON.stringify({ pId: id });
    var servicePruebas = new ServicioEnClases.ServicioPruebasResistencia();
    servicePruebas.comprobarPruebaResistencia(datos, onSuccessComprobarPruebas, null, null);
    //serviceRol.EliminarRoles(datos, onSuccesEliminar, errorMessage, null, null);
});


function onSuccessComprobarPruebas(result) {
    var objeto = $.parseJSON(result);

    var rows = $('tr.selected');
    var table = $('#tblUsuarios').DataTable();
    var rowData = table.rows(rows).data();
    var id = rowData[0][1];


    if (objeto == true) {
        window.location = "../PruebasResistencia/PruebaResistencia.aspx?id=" + id;

    } else {
        if (confirm('Este Cliente no ha realizado la prueba de resistencia. Desea aplicar la prueba?')) {
            window.location = "PruebaResistencia.aspx";
        } else {
            // Do nothing!
        }

    }
}

$('#btnFichaMedicion').click(function () {
    var rows = $('tr.selected');
    var table = $('#tblUsuarios').DataTable();
    var rowData = table.rows(rows).data();
    var idCliente = rowData[0][0];
    var genero = rowData[0][5];
    window.location = "../FichasDeMedicion/Index.aspx?id=" + idCliente + "genero" + genero;
})