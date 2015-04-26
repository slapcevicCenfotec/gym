$(document).ready(function () {
    var serviceBuscarTiposMaquina = new ServiciosTiposDeMaquinas();
    serviceBuscarTiposMaquina.obtenerTiposDeMaquinas(onSuccessTiposDeMaquinas, null, null);

    var idMaquina = getQueryVariable('id');

    var serviceBuscarMaquinaPorId = new ServiciosMaquinas();
    serviceBuscarMaquinaPorId.obtenerMaquinaById(idMaquina, onSuccessObtenerMaquina, null , null);
});

function onSuccessTiposDeMaquinas(result) {
    var objeto = $.parseJSON(result);
    var cmbTiposDeMaquinas = document.getElementById('cmbTiposDeMaquinas');
    //$.each(objeto, function (i, item) {
    //    var idMaquina = objeto[i].Id;
    //    var nombreMaquina = objeto[i].Nombre;
    //    var option = document.createElement("option");
    //    option.text = nombreMaquina;
    //    option.value = idMaquina
    //    cmbTiposDeMaquinas.appendChild(option);
    //});

    $.each(objeto, function (i, item) {
        $("#cmbTiposDeMaquinas").append("<option value=\"" + objeto[i].Id + "\">" + objeto[i].Nombre + "</option>");
    });
}

function onSuccessObtenerMaquina(result) {
    var objeto = $.parseJSON(result);

    var tipoMaquina = objeto['TipoDeMaquina'];

    console.log(objeto['TipoDeMaquina']);

    console.log(objeto.TipoDeMaquina);

    $('#txtNumeroActivo').val(objeto['NumeroActivo']);
    $('#txtNumeroMaquina').val(objeto['NumeroMaquina']);

    $("#cmbTiposDeMaquinas option[value=" + objeto.TipoDeMaquina + "]").attr("selected", true);

    //$("#musculo-principal option[value=" + objeto.itemMusculo + "]").attr("selected", true);

    $('#idMaquina').val(objeto['Id']);
    $('#habilitado').val(objeto['Habilitado']);
}

$('#btnGuardar').click(function () {
    $("#ModificarForm").validate();

    if ($("#ModificarForm").valid()) {
        var numeroActivo = $('#txtNumeroActivo').val(),
            numeroMaquina = $('#txtNumeroMaquina').val(),
            tipoMaquina = $('#cmbTiposDeMaquinas option:selected').val(),
            id = $('#idMaquina').val(),
            habilitado = $('#habilitado').val(),

        serviceModificar = new ServiciosMaquinas();

        datos = JSON.stringify({ pid: id, pnumeroActivo: numeroActivo, pnumeroMaquina: numeroMaquina, phabilitado: habilitado, ptipoMaquina: tipoMaquina });
        serviceModificar.modificarMaquina(datos, onSuccesModificarMaquina, errorMessage, null, null);

        window.location = 'Index.aspx';
    }
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

$('#btnCancelar').click(function () {
    $("#ModificarForm").trigger('reset');
    window.location = 'Index.aspx';
})




