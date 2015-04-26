var nombre = document.querySelector('#txtNombre');
var monto = document.querySelector('#txtMonto');
var duracion = document.querySelector('#txtDuracion');

$("#txtNombre").blur(function () {
    validarInput(nombre, 'STRING');
});

$("#txtMonto").blur(function () {
    validarInput(monto, 'INT');
});

$("#txtDuracion").blur(function () {
    validarInput(duracion, 'INT');
});

$("#btnRegistarTipoDePago").click(function () {
    auxNombre = validarInput(nombre, 'STRING');
    auxMonto = validarInput(monto, 'INT');
    auxDuracion = validarInput(duracion, 'INT');

    if (auxNombre && auxMonto && auxDuracion) {
        alert("todo bien!");
    }
});

function validarInput(entrada,tipo) {
    var error = 0;
    if ($.trim(entrada.value) == "") {
        entrada.parentNode.classList.add('has-error');
        error++;
    } else {
        entrada.parentNode.classList.remove('has-error');
        switch (tipo) {
            case 'STRING':
                if (/^[a-zA-Z]+$/.test(entrada.value)) {
                    entrada.parentNode.classList.remove('has-error');
                } else {
                    entrada.parentNode.classList.add('has-error');
                    error++;
                }
                break;
            case 'INT':
                if (isNaN(entrada.value)) {
                    entrada.parentNode.classList.add('has-error');
                    error++;
                } else {
                    entrada.parentNode.classList.remove('has-error');
                }
                break;            
        }
        if (error == 0) {
            return true;
        } else {
            return false;
        }
    }
}

function message() {
   
}


