var objeto;
var hayGraficoPeso = false;
var hayGraficoImc = false;
var hayGraficoPorcGrasa = false;
var hayGraficoPorcMasa = false;
var hayGraficoPesoGraso = false;

$(document).ready(function () {
    var cliente = 122;
    var serviceBuscar = new ServicioFichasDeMedicion();
    serviceBuscar.obtenerFichasPorCliente(cliente, onSuccessBuscarFichas, null, null);
});

function onSuccessBuscarFichas(result) {
    objeto = $.parseJSON(result);
    var cmbTiposDeMaquinas = document.getElementById('cmbDesde');
    var cmbTiposDeMaquinas = document.getElementById('cmbHasta');

    $.each(objeto, function (i, item) {
        $("#cmbDesde").append("<option value=\"" + objeto[i].Id + "\">" + parseJsonDate(objeto[i].FechaCreacion) + "</option>");
        $("#cmbHasta").append("<option value=\"" + objeto[i].Id + "\">" + parseJsonDate(objeto[i].FechaCreacion) + "</option>");
    });
}

$('.GenerarGraficoPeso').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datosPeso = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

        if (hayGraficoPeso == false) {

            hayGraficoPeso = true;

            $.each(objeto, function (i, item) {
                if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
                    datosPeso.push({
                        x: parseJsonDate(objeto[i].FechaCreacion),
                        peso: objeto[i].Peso
                    });
                }
            });

            if ($('#graficoPeso').length > 0) {
                var labelColor = $('#graficoPeso').css('color');
                Morris.Area({
                    element: 'graficoPeso',
                    behaveLikeLine: true,
                    data: datosPeso,
                    xkey: 'x',
                    ykeys: ['peso'],
                    labels: ['Peso'],
                    gridTextColor: labelColor,
                    lineColors: $('#graficoPeso').data('colors').split(',')
                });
            }
        }
    }
})

$('.GenerarGraficoIMC').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datosIMC = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

        if (hayGraficoImc == false) {

            hayGraficoImc = true;

            $.each(objeto, function (i, item) {
                if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
                    datosIMC.push({
                        x: parseJsonDate(objeto[i].FechaCreacion),
                        imc: objeto[i].Imc
                    });
                }
            });

            if ($('#graficoImc').length > 0) {
                var labelColor = $('#graficoImc').css('color');
                Morris.Area({
                    element: 'graficoImc',
                    behaveLikeLine: true,
                    data: datosIMC,
                    xkey: 'x',
                    ykeys: ['imc'],
                    labels: ['IMC'],
                    gridTextColor: labelColor,
                    lineColors: $('#graficoImc').data('colors').split(',')
                });
            }

        }

    }
})

$('.GenerarGraficoPorcGrasa').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datosPorcGrasa = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

        if (hayGraficoPorcGrasa == false) {

            hayGraficoPorcGrasa = true;

            $.each(objeto, function (i, item) {
                if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
                    datosPorcGrasa.push({
                        x: parseJsonDate(objeto[i].FechaCreacion),
                        porcGrasa: objeto[i].PorcentajeGrasaCorporal
                    });
                }
            });

            if ($('#graficoPorcGrasa').length > 0) {
                var labelColor = $('#graficoPorcGrasa').css('color');
                Morris.Area({
                    element: 'graficoPorcGrasa',
                    behaveLikeLine: true,
                    data: datosPorcGrasa,
                    xkey: 'x',
                    ykeys: ['porcGrasa'],
                    labels: ['Porcentaje de grasa'],
                    gridTextColor: labelColor,
                    lineColors: $('#graficoPorcGrasa').data('colors').split(',')
                });
            }
        }

    }
})

$('.GenerarGraficoPorcMasa').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datosPorcMasa = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

        if (hayGraficoPorcMasa == false) {

            hayGraficoPorcMasa = true;

            $.each(objeto, function (i, item) {
                if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
                    datosPorcMasa.push({
                        x: parseJsonDate(objeto[i].FechaCreacion),
                        porcMasa: objeto[i].PorcentajeMasaMuscular
                    });
                }
            });

            if ($('#graficoPorcMasa').length > 0) {
                var labelColor = $('#graficoPorcMasa').css('color');
                Morris.Area({
                    element: 'graficoPorcMasa',
                    behaveLikeLine: true,
                    data: datosPorcMasa,
                    xkey: 'x',
                    ykeys: ['porcMasa'],
                    labels: ['Porcentaje de masa'],
                    gridTextColor: labelColor,
                    lineColors: $('#graficoPorcMasa').data('colors').split(',')
                });
            }
        }

    }
})

$('.GenerarGraficoPesoGraso').click(function () {
    var desde = $('#cmbDesde').val();
    var hasta = $('#cmbHasta').val();
    var datosPesoGraso = new Array;

    if (desde > hasta) {
        console.log(desde);
        console.log(hasta);
        alert('Fecha inicial no debe de ser mayor a la final');

        location.reload();
    } else {

        if (hayGraficoPesoGraso == false) {

            hayGraficoPesoGraso = true;

            $.each(objeto, function (i, item) {
                if (objeto[i].Id >= desde && objeto[i].Id <= hasta) {
                    datosPesoGraso.push({
                        x: parseJsonDate(objeto[i].FechaCreacion),
                        pesoGraso: objeto[i].PesoGraso
                    });
                }
            });

            if ($('#graficoPesoGraso').length > 0) {
                var labelColor = $('#graficoPesoGraso').css('color');
                Morris.Area({
                    element: 'graficoPesoGraso',
                    behaveLikeLine: true,
                    data: datosPesoGraso,
                    xkey: 'x',
                    ykeys: ['pesoGraso'],
                    labels: ['Peso graso'],
                    gridTextColor: labelColor,
                    lineColors: $('#graficoPesoGraso').data('colors').split(',')
                });
            }
        }

    }
})

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

    return [year, month, day].join('-');
}

