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
    $('#fechaCreacionModificar').val(parseJsonDate(objeto['FechaCreacion']));
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
        var idFichaModificar = parseFloat($('#idFichaModificar').val()),
            fechaCreacionModificar = $('#fechaCreacionModificar').val(),
            clienteModificar = parseFloat($('#clienteModificar').val()),
            peso = parseFloat($('#txtPeso').val()),
            altura = parseFloat($('#txtAltura').val()),
            altura = parseFloat($('#txtAltura').val()),
            imc = parseFloat($('#txtIMC').val()),
            clasificacionIMC = $('#txtClasificacionIMC').val(),
            porcentajeGrasa = parseFloat($('#txtPorcGrasa').val()),
            porcentajeMasa = parseFloat($('#txtPorcMasaMuscular').val()),
            pesoGraso = parseFloat($('#txtPesoGraso').val()),
            cintura = parseFloat($('#txtCintura').val()),
            cadera = parseFloat($('#txtCadera').val()),
            abdomen = parseFloat($('#txtAbdomen').val()),
            pecho = parseFloat($('#txtPecho').val()),
            espalda = parseFloat($('#txtEspalda').val()),
            musloIzquierdo = parseFloat($('#txtMusloIzquierdo').val()),
            musloDerecho = parseFloat($('#txtMusloDerecho').val()),
            bicepsIzquierdo = parseFloat($('#txtBicepIzquierdo').val()),
            bicepsDerecho = parseFloat($('#txtBicepDerecho').val()),
            bicepIzquierdoContr = parseFloat($('#txtBicepIzquierdoContr').val()),
            bicepDerechoContr = parseFloat($('#txtBicepDerechoContr').val()),
            pantorrillaIzquierda = parseFloat($('#txtPantorrillaIzquierda').val()),
            pantorrillaDerecha = parseFloat($('#txtPantorrillaDerecha').val()),
            abdominalIzquierdo = parseFloat($('#txtAbdominalIzquierdo').val()),
            abdominalDerecho = parseFloat($('#txtAbdominalDerecho').val()),
            pliegueMusloIzquierdo = parseFloat($('#txtPliegueMusloIzquierdo').val()),
            pliegueMusloDerecho = parseFloat($('#txtPliegueMusloDerecho').val()),
            plieguePantorrillaIzquierda = parseFloat($('#txtPlieguePantorrillaIzquierda').val()),
            plieguePantorrillaDerecha = parseFloat($('#txtPlieguePantorrillaDerecha').val()),
            tricepsIzquierdo = parseFloat($('#txtTricepsIzquierdo').val()),
            tricepsDerecho = parseFloat($('#txtTricepsDerecho').val()),
            subescapularIzquierdo = parseFloat($('#txtSubescapularIzquierdo').val()),
            subescapularDerecho = parseFloat($('#txtSubescapularDerecho').val()),
            supraespinalIzquierdo = parseFloat($('#txtSupraespinalIzquierdo').val()),
            supraespinalDerecho = parseFloat($('#txtSupraespinalDerecho').val()),
            habilitadoModificar = parseFloat($('#habilitadoModificar').val());

        var servicioModificar = new ServicioFichasDeMedicion();

        var datos = JSON.stringify({
            pid: idFichaModificar,
            pfecha: fechaCreacionModificar,
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

        console.log(datos);
        servicioModificar.modificarFichaDeMedicion(datos, onSuccesModificarFicha, errorMessage, null, null);
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
        case (imc > 16 && imc < 16.99):
            clasificacionIMC = "Delgadez moderada";
            break;
        case (imc > 17 && imc < 18.49):
            clasificacionIMC = "Delgadez leve";
            break;
        case (imc > 18.5 && imc < 24.99):
            clasificacionIMC = "Peso normal";
            break;
        case (imc > 25 && imc < 29.99):
            clasificacionIMC = "Pre obesidad";
            break;
        case (imc > 30 && imc < 34.99):
            clasificacionIMC = "Obesidad leve";
            break;
        case (imc > 35 && imc < 39.99):
            clasificacionIMC = "Obesidad media";
            break;
        case (imc > 40):
            clasificacionIMC = "Obesidad morbida";
            break;
    }

    $("label[for='txtIMC']").text("");
    $("label[for='txtClasificacionIMC']").text("");
    $('#txtIMC').val(imc);
    $('#txtClasificacionIMC').val(clasificacionIMC);

    return imc;
};

function calcularPorcGrasa() {

    //asignar genero con variable de sesion.

    var genero = 'm',
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

    if (genero == 'm') {
        constante = 0.1051;
    } else {
        constante = 0.1548;
    }

    sumatoriaPliegues = abdominalIzq + abdominalDer + musloIzq + musloDer + pantorrillaIzq + pantorrillaDer +
    tricepsIzq + tricepsDer + subescapularIzq + subescapularDer + supraespinalIzq + supraespinalDer;

    porcentajeGrasa = constante * sumatoriaPliegues + 2.585;
    pesoGraso = (peso * porcentajeGrasa) / 100;
    porcentajeMasa = peso - pesoGraso;

    $('#txtPorcGrasa').val(porcentajeGrasa);
    $('#txtPesoGraso').val(pesoGraso);
    $('#txtPorcMasaMuscular').val(porcentajeMasa);
    $("label[for='txtPorcGrasa']").text("");
    $("label[for='txtPesoGraso']").text("");
    $("label[for='txtPorcMasaMuscular']").text("");
};

$('#btnCalcular').click(function () {

    if ($('#txtPeso').val() == "" || $('#txtAltura').val() == "") {
        alert('Llenar los espacios requeridos');
    }
    else {
        calcularIMC();
        calcularPorcGrasa();
    }
});




