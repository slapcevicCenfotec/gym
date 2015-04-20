$(document).ready(function () {
    var serviceBuscarTiposMaquina = new ServicioEnClases.ServiciosTiposDeMaquinas();
    serviceBuscarTiposMaquina.obtenerTiposDeMaquinas(onSuccessTiposDeMaquinas, null, null);

    var idMaquina = getQueryVariable('id');

    var serviceBuscarMaquinaPorId = new ServicioEnClases.ServiciosMaquina();
    serviceBuscarMaquinaPorId.obtenerMaquinaById(idMaquina, onSuccessObtenerMaquina, null , null);
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

function onSuccessObtenerMaquina(result) {
    var objeto = $.parseJSON(result);

    $('#txtNumeroActivo').val(objeto['NumeroActivo']);
    $('#txtNumeroMaquina').val(objeto['NumeroMaquina']);
    $('#cmbTiposDeMaquinas').val(objeto['TipoDeMaquina']);
}

$('#btnGuardar').click(function () {
    var numeroActivo = $('#txtNumeroActivo').val(),
        numeroMaquina = $('#txtNumeroMaquina').val(),
        tipoMaquina = $('#cmbTiposDeMaquinas option:selected').val();
    serviceModificar = new ServicioEnClases.ServiciosMaquina();

    id = getQueryVariable('id');
    habilitado = getQueryVariable('habilitado');

    datos = JSON.stringify({ pid:id, pnumeroActivo:numeroActivo, pnumeroMaquina:numeroMaquina, phabilitado:habilitado, ptipoMaquina:tipoMaquina});
    serviceModificar.modificarMaquina(datos, onSuccesModificarMaquina, errorMessage, null, null);
})

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split('&');
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split('=');
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
}

function onSuccesModificarMaquina(result) {
    alert('Se registró correctamente la máquina');
}

function errorMessage(resul) {
    alert(resul.get_message());
}




