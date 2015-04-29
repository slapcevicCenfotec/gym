var tipo = document.querySelector('#txtTipo');
var monto = document.querySelector('#txtMonto');
var factura = document.querySelector('#txtFactura');
var desde = document.querySelector('#txtDesde');
var hasta = document.querySelector('#txtHasta');


$("#txtTipo").blur(function () {
    validarInput(tipo,'SELECT');
});

$("#txtMonto").blur(function () {
    validarInput(monto, 'INT');
});

$("#txtFactura").blur(function () {
    validarInput(factura, 'SPC');
});

$("#txtDesde").blur(function () {
    validarInput(desde, 'SPC');
});

$("#txtHasta").blur(function () {
    validarInput(hasta, 'SPC');
});

$("#btnRegistrarPago").click(function () {
    auxTipo = validarInput(tipo, 'SELECT');
    auxMonto = validarInput(monto, 'INT');
    auxFactura = validarInput(factura, 'SPC');
    auxDesde = validarInput(desde, 'SPC');
    auxHasta = validarInput(hasta, 'SPC');
    

    if (auxTipo && auxMonto && auxFactura && auxDesde && auxHasta) {

        var rows = $('tr.selected');
        var table = $('#tblUsuarios').DataTable();
        var rowData = table.rows(rows).data();
        var id = rowData[0][0];
        alert("boton" + id);

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
            case 'SELECT':
                if (entrada.value == 0) {
                    entrada.parentNode.classList.add('has-error');
                    error++;
                } else {
                    entrada.parentNode.classList.remove('has-error');
                }
                break;
            case 'SPC':
               
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


