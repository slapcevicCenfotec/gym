function search() {
    var serviceBuscar = new ServiciosTiposDeMaquinas();
    serviceBuscar.obtenerTiposDeMaquinas(onSuccessTiposDeMaquinas, null, null);
}

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

    $('#cmbTiposDeMaquinas').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            $('#cmbTiposDeMaquinas').$('li.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });
}

$('#btnGuardar').click(function () {
    $("#maquinasForm").validate();

    if ($("#maquinasForm").valid()) {

        var numeroActivo = $('#txtNumeroActivo').val(),
            numeroMaquina = $('#txtNumeroMaquina').val(),
            tipoMaquina = $('#cmbTiposDeMaquinas option:selected').val();
        serviceInsertar = new ServiciosMaquinas();

        datos = JSON.stringify({ pnumeroActivo: numeroActivo, pnumeroMaquina: numeroMaquina, ptipoMaquina: tipoMaquina });
        serviceInsertar.insertarMaquina(datos, onSuccesIngresarMaquina, errorMessage, null, null);

        window.location = 'Index.aspx';
    }
})

function onSuccesIngresarMaquina(result) {
    window.location = 'Index.aspx?agregado';
    //alert('Se registró correctamente la máquina');
}

function errorMessage(resul) {
    toastr.success('La maquina no pudo ser registrada');
    //alert(resul.get_message());
}

$('#btnCancelar').click(function () {
    $("#maquinasForm").trigger('reset');
    window.location = 'Index.aspx';
})