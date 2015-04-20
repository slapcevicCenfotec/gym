$(document).ready(function () {
    var serviceBuscar = new ServicioEnClases.ServiciosTiposDeMaquinas();
    serviceBuscar.obtenerTiposDeMaquinas(onSuccessTiposDeMaquinas, null, null);
});

function onSuccessTiposDeMaquinas(result) {
    var objeto = $.parseJSON(result);
    var cmbTiposDeMaquinas = document.getElementById('cmbTiposDeMaquinas');
    $.each(objeto, function (i, item) {
        var nombreMaquina = objeto[i].Nombre;
        var idMaquina = objeto[i].Id;
        var option = document.createElement("option");
        option.textContent = nombreMaquina;
        option.value = idMaquina
        cmbTiposDeMaquinas.appendChild(option);
    });
}

$('#btnGuardar').click(function () {
    var numeroActivo = $('#txtNumeroActivo').val(),
        numeroMaquina = $('#txtNumeroMaquina').val(),
        tipoMaquina = $('#cmbTiposDeMaquinas option:selected').val();
        serviceInsertar = new ServicioEnClases.ServiciosMaquina();

        datos = JSON.stringify({ pnumeroActivo: numeroActivo, pnumeroMaquina: numeroMaquina, ptipoMaquina: tipoMaquina });
        serviceInsertar.insertarMaquina(datos, onSuccesIngresarMaquina, errorMessage, null, null);
})

function onSuccesIngresarMaquina(result) {
    alert('Se registró correctamente la máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}