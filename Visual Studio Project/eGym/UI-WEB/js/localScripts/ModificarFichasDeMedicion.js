$(document).ready(function () {
    $('.readOnly').prop('disabled', true);

    var idFicha = getQueryVariable('id');

    var serviceBuscarFichaPorId = new ServicioFichasDeMedicion();
    serviceBuscarFichaPorId.obtenerFichaById(idFicha, onSuccessObtenerFicha, null, null);
});

$('.soloNumeros').keypress(function (evt) {
    $return = true;
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
        $return = false;
    $val = $(evt.originalTarget).val();
    if (charCode == 46) {
        if (count_appearance($val, '.') > 0) {
            $return = false;
        }
        if ($val.length == 0) {
            $return = false;
        }
    }
    return $return;
});

function onSuccessObtenerFicha(result) {
    var objeto = $.parseJSON(result);

    $('#idFichaModificar').val(objeto['Id']);
    $('#clienteModificar').val(objeto['Cliente']);
    $('#habilitadoModificar').val(objeto['Habilitado']);
    $('#txtPeso').val(objeto['Peso']);
    $('#txtAltura').val(objeto['Altura']);
    $('#txtIMC').val(objeto['Imc']);
    $('#txtClasificacionIMC').val(objeto['ClasificacionIMC']);
    $('#txtPorcGrasa').val(objeto['PorcentajeGrasaCorporal']);
    $('#txtPorcMasaMuscular').val(objeto['PorcentajeMasaMuscular']);
    $('#txtPesoGraso').val(objeto['PesoGraso']);
    $('#txtCintura').val(objeto['PerCintura']);
    $('#txtCadera').val(objeto['PerCadera']);
    $('#txtAbdomen').val(objeto['PerAbdomen']);
    $('#txtPecho').val(objeto['PerPecho']);
    $('#txtEspalda').val(objeto['PerEspalda']);
    $('#txtMusloIzquierdo').val(objeto['PerMusloIzquierdo']);
    $('#txtMusloDerecho').val(objeto['PerMusloDerecho']);
    $('#txtBicepIzquierdo').val(objeto['PerBicepsIzquierdo']);
    $('#txtBicepDerecho').val(objeto['PerBicepsDerecho']);
    $('#txtBicepIzquierdoContr').val(objeto['PerBicepsIzqContraido']);
    $('#txtBicepDerechoContr').val(objeto['PerBicepsDerContraido']);
    $('#txtPantorrillaIzquierda').val(objeto['PerPantorrillaIzquierda']);
    $('#txtPantorrillaDerecha').val(objeto['PerPantorrillaDerecha']);
    $('#txtAbdominalIzquierdo').val(objeto['PliAbdominalIzquierdo']);
    $('#txtAbdominalDerecho').val(objeto['PliAbdominalDerecho']);
    $('#txtPliegueMusloIzquierdo').val(objeto['PliMusloIzquierdo']);
    $('#txtPliegueMusloDerecho').val(objeto['PliMusloDerecho']);
    $('#txtPlieguePantorrillaIzquierda').val(objeto['PliPantorrillaIzquierda']);
    $('#txtPlieguePantorrillaDerecha').val(objeto['PliPantorrillaDerecha']);
    $('#txtTricepsIzquierdo').val(objeto['PliTricepsIzquierdo']);
    $('#txtTricepsDerecho').val(objeto['PliTricepsDerecho']);
    $('#txtSubescapularIzquierdo').val(objeto['PliSubescapularIzquierdo']);
    $('#txtSubescapularDerecho').val(objeto['PliSubescapularDerecho']);
    $('#txtSupraespinalIzquierdo').val(objeto['PliSupraespinalIzquierdo']);
    $('#txtSupraespinalDerecho').val(objeto['PliSupraespinalDerecho']);
}

$('#btnGuardar').click(function () {
    $("#modificarFichasForm").validate();

    if ($("#modificarFichasForm").valid()) {
        var idFichaModificar = $('#idFichaModificar').val(),
            clienteModificar = $('#clienteModificar').val(),
            peso = $('#txtPeso').val().toString().replace(/\./g, ','),
            altura = $('#txtAltura').val().toString().replace(/\./g, ','),
            imc = $('#txtIMC').val().toString().replace(/\./g, ','),
            clasificacionIMC = $('#txtClasificacionIMC').val(),
            porcentajeGrasa = $('#txtPorcGrasa').val().toString().replace(/\./g, ','),
            porcentajeMasa = $('#txtPorcMasaMuscular').val().toString().replace(/\./g, ','),
            pesoGraso = $('#txtPesoGraso').val().toString().replace(/\./g, ','),
            cintura = $('#txtCintura').val().toString().replace(/\./g, ','),
            cadera = $('#txtCadera').val().toString().replace(/\./g, ','),
            abdomen = $('#txtAbdomen').val().toString().replace(/\./g, ','),
            pecho = $('#txtPecho').val().toString().replace(/\./g, ','),
            espalda = $('#txtEspalda').val().toString().replace(/\./g, ','),
            musloIzquierdo = $('#txtMusloIzquierdo').val().toString().replace(/\./g, ','),
            musloDerecho = $('#txtMusloDerecho').val().toString().replace(/\./g, ','),
            bicepsIzquierdo = $('#txtBicepIzquierdo').val().toString().replace(/\./g, ','),
            bicepsDerecho = $('#txtBicepDerecho').val().toString().replace(/\./g, ','),
            bicepIzquierdoContr = $('#txtBicepIzquierdoContr').val().toString().replace(/\./g, ','),
            bicepDerechoContr = $('#txtBicepDerechoContr').val().toString().replace(/\./g, ','),
            pantorrillaIzquierda = $('#txtPantorrillaIzquierda').val().toString().replace(/\./g, ','),
            pantorrillaDerecha = $('#txtPantorrillaDerecha').val().toString().replace(/\./g, ','),
            abdominalIzquierdo = $('#txtAbdominalIzquierdo').val().toString().replace(/\./g, ','),
            abdominalDerecho = $('#txtAbdominalDerecho').val().toString().replace(/\./g, ','),
            pliegueMusloIzquierdo = $('#txtPliegueMusloIzquierdo').val().toString().replace(/\./g, ','),
            pliegueMusloDerecho = $('#txtPliegueMusloDerecho').val().toString().replace(/\./g, ','),
            plieguePantorrillaIzquierda = $('#txtPlieguePantorrillaIzquierda').val().toString().replace(/\./g, ','),
            plieguePantorrillaDerecha = $('#txtPlieguePantorrillaDerecha').val().toString().replace(/\./g, ','),
            tricepsIzquierdo = $('#txtTricepsIzquierdo').val().toString().replace(/\./g, ','),
            tricepsDerecho = $('#txtTricepsDerecho').val().toString().replace(/\./g, ','),
            subescapularIzquierdo = $('#txtSubescapularIzquierdo').val().toString().replace(/\./g, ','),
            subescapularDerecho = $('#txtSubescapularDerecho').val().toString().replace(/\./g, ','),
            supraespinalIzquierdo = $('#txtSupraespinalIzquierdo').val().toString().replace(/\./g, ','),
            supraespinalDerecho = $('#txtSupraespinalDerecho').val().toString().replace(/\./g, ','),
            habilitadoModificar = $('#habilitadoModificar').val();

        var servicioModificar = new ServicioFichasDeMedicion();

        var datos = JSON.stringify({
            pid: idFichaModificar,
            pcliente: clienteModificar,
            ppeso: peso,
            paltura: altura,
            pimc: imc,
            pclasificacionIMC: clasificacionIMC,
            pporcentajeGrasa: porcentajeGrasa,
            pporcentajeMasa: porcentajeMasa,
            ppesoGraso: pesoGraso,
            pcintura: cintura,
            pcadera: cadera,
            pabdomen: abdomen,
            ppecho: pecho,
            pespalda: espalda,
            pmusloIzquierdo: musloIzquierdo,
            pmusloDerecho: musloDerecho,
            pbicepsIzquierdo: bicepsIzquierdo,
            pbicepsDerecho: bicepsDerecho,
            pbicepIzquierdoContr: bicepIzquierdoContr,
            pbicepDerechoContr: bicepDerechoContr,
            ppantorrillaIzquierda: pantorrillaIzquierda,
            ppantorrillaDerecha: pantorrillaDerecha,
            pabdominalIzquierdo: abdominalIzquierdo,
            pabdominalDerecho: abdominalDerecho,
            ppliegueMusloIzquierdo: pliegueMusloIzquierdo,
            ppliegueMusloDerecho: pliegueMusloDerecho,
            pplieguePantorrillaIzquierda: plieguePantorrillaIzquierda,
            pplieguePantorrillaDerecha: plieguePantorrillaDerecha,
            ptricepsIzquierdo: tricepsIzquierdo,
            ptricepsDerecho: tricepsDerecho,
            psubescapularIzquierdo: subescapularIzquierdo,
            psubescapularDerecho: subescapularDerecho,
            psupraespinalIzquierdo: supraespinalIzquierdo,
            psupraespinalDerecho: supraespinalDerecho,
            phabilitado: habilitadoModificar
        });

        servicioModificar.modificarFichaDeMedicion(datos, onSuccesModificarFicha, errorMessage, null, null);

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

function onSuccesModificarFicha(result) {
    alert('Se modificó correctamente la ficha');
}

function errorMessage(resul) {
    alert(resul.get_message());
}

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split('&');
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split('=');
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
}

function parseJsonDate(jsonDateString) {
    var date = new Date(parseInt(jsonDateString.replace('/Date(', '')));
    return formattedDate(date);
}

function formattedDate(date) {
    var d = new Date(date || Date.now()),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [month, day, year].join('/');
}

function calcularIMC() {
    var peso = $('#txtPeso').val(),
        altura = $('#txtAltura').val() / 100,
        imc = peso / (altura * altura),
        clasificacionIMC;

    switch (true) {
        case (imc < 16):
            clasificacionIMC = "Delgadez severa";
            break;
        case (imc >= 16 && imc <= 16.99):
            clasificacionIMC = "Delgadez moderada";
            break;
        case (imc >= 17 && imc <= 18.49):
            clasificacionIMC = "Delgadez leve";
            break;
        case (imc >= 18.5 && imc <= 24.99):
            clasificacionIMC = "Peso normal";
            break;
        case (imc >= 25 && imc <= 29.99):
            clasificacionIMC = "Pre obesidad";
            break;
        case (imc >= 30 && imc <= 34.99):
            clasificacionIMC = "Obesidad leve";
            break;
        case (imc >= 35 && imc <= 39.99):
            clasificacionIMC = "Obesidad media";
            break;
        case (imc > 40):
            clasificacionIMC = "Obesidad morbida";
            break;
    }

    $('#txtIMC').val(imc.toFixed(2));
    $('#txtClasificacionIMC').val(clasificacionIMC);

    return imc;
};

function calcularPorcGrasa() {

    var genero = getQueryVariable('idGenero'),
        constante,
        porcentajeGrasa,
        sumatoriaPliegues,
        pesoGraso,
        porcentajeMasa,
        peso = parseFloat($('#txtPeso').val()),
        abdominalIzq = parseFloat($('#txtAbdominalIzquierdo').val()),
        abdominalDer = parseFloat($('#txtAbdominalDerecho').val()),
        musloIzq = parseFloat($('#txtPliegueMusloIzquierdo').val()),
        musloDer = parseFloat($('#txtPliegueMusloDerecho').val()),
        pantorrillaIzq = parseFloat($('#txtPlieguePantorrillaIzquierda').val()),
        pantorrillaDer = parseFloat($('#txtPlieguePantorrillaDerecha').val()),
        tricepsIzq = parseFloat($('#txtTricepsIzquierdo').val()),
        tricepsDer = parseFloat($('#txtTricepsDerecho').val()),
        subescapularIzq = parseFloat($('#txtSubescapularIzquierdo').val()),
        subescapularDer = parseFloat($('#txtSubescapularDerecho').val()),
        supraespinalIzq = parseFloat($('#txtSupraespinalIzquierdo').val()),
        supraespinalDer = parseFloat($('#txtSupraespinalDerecho').val());


    if (genero == 1) {
        constante = 0.1051;
    } else {
        constante = 0.1548;
    }


    sumatoriaPliegues = abdominalIzq + abdominalDer + musloIzq + musloDer + pantorrillaIzq + pantorrillaDer +
    tricepsIzq + tricepsDer + subescapularIzq + subescapularDer + supraespinalIzq + supraespinalDer;

    porcentajeGrasa = constante * sumatoriaPliegues + 2.585;
    pesoGraso = (peso * porcentajeGrasa) / 100;
    porcentajeMasa = peso - pesoGraso;

    $('#txtPorcGrasa').val(porcentajeGrasa.toFixed(2));
    $('#txtPesoGraso').val(pesoGraso.toFixed(2));
    $('#txtPorcMasaMuscular').val(porcentajeMasa.toFixed(2));
};

$('#btnCalcular').click(function () {

    if ($('#txtPeso').val() == "" || $('#txtAltura').val() == "") {
        alert('Llenar los espacios requeridos');
    }
    else {
        calcularIMC();
        calcularPorcGrasa();
    }
})

$('#btnCancelar').click(function () {
    $("#maquinasForm").trigger('reset');
    window.location = 'Index.aspx';
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



