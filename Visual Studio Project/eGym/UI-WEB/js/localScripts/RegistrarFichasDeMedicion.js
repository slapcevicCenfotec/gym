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


    var genero = getQueryVariable('genero'),
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

$('#btnGuardar').click(function () {
    $("#fichasForm").validate();

    if ($("#fichasForm").valid()) {

        var cliente = getQueryVariable('id');
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
        supraespinalDerecho = $('#txtSupraespinalDerecho').val().toString().replace(/\./g, ',');       

        var servicioIngresar = new ServicioFichasDeMedicion();

        var datos = JSON.stringify({
            pcliente: cliente,
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

        window.location = 'Index.aspx';
    }

})

function onSuccesIngresar(result) {
    alert('Se registró correctamente la ficha de medición');
}

function errorMessage(resul) {
    alert(resul.get_message());
}

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
