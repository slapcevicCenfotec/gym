$(document).ready(function () {
    $('.readOnly').prop('disabled', true);
});

$('#btnCalcular').click(function () {

    if ($('#txtPeso').val() == "" || $('#txtAltura').val() == "") {
        alert('Llenar los espacios requeridos');
    }
    else {
        calcularIMC();
        calcularPorcGrasa();
    }
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

function calcularIMC() {
    var peso = $('#txtPeso').val(),
        altura = $('#txtAltura').val()/100,
        imc = peso / (altura * altura),
        clasificacionIMC;

    switch(true) {
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

$('#btnGuardar').click(function () {
    $("#fichasForm").validate();

    if ($("#fichasForm").valid()) {
        var cliente = 122,
        fecha = '04/04/2015',
        peso = parseFloat($('#txtPeso').val()),
        altura = parseFloat($('#txtAltura').val()),
        imc = parseFloat($('#txtIMC').val()),
        clasificacionIMC = parseFloat($('#txtClasificacionIMC').val()),
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
        supraespinalDerecho = parseFloat($('#txtSupraespinalDerecho').val());

        var servicioIngresar = new ServicioFichasDeMedicion();

        var datos = JSON.stringify({
            pcliente: cliente,
            pfecha: fecha,
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
            psupraespinalDerecho: supraespinalDerecho
        });


        servicioIngresar.insertarFichaDeMedicion(datos, onSuccesIngresar, errorMessage, null, null);
    }

})

function onSuccesIngresar(result) {
    alert('Se registró correctamente la ficha de medición');
}

function errorMessage(resul) {
    alert(resul.get_message());
}
